$prefix = Read-Host -Prompt "Please input your prefix"
$userDisplayName = Read-Host -Prompt "Please input the displayname of your user account"

#Hent brugeren til Key Vault med videre
$user = get-azaduser -DisplayName $userDisplayName

$parameters = @{
    prefix = $prefix;
    userObjectId = $user.Id.toString()
}

$resourceGroup = Get-AzResourceGroup -Name $prefix

if($resourceGroup -ne $null)
{
    write-host "Removing resourcegroup $prefix" -ForegroundColor Green
    Remove-AzResourceGroup -Name $prefix -ErrorAction Stop -WarningAction SilentlyContinue
}

New-AzResourceGroup -Name $prefix -Location "WestEurope"

$outputStorage = New-AzResourceGroupDeployment -ResourceGroupName $prefix -TemplateFile .\StorageAccount-template.json -Name "DemoStorageAccount" -TemplateParameterObject $parameters

$parameters.Add('storageaccountconnectionstring',$outputStorage.Outputs["storageAccountConnectionString"].Value)

$outputKeyVault = New-AzResourceGroupDeployment -ResourceGroupName $prefix -TemplateFile .\keyvault-template.json -Name "DemoKeyvault" -TemplateParameterObject $parameters

$parameters.Add('storageaccountkeyvaulturl',$outputKeyVault.Outputs["storageaccountsecreturi"].Value)

$parameters

$outputWebsite =New-AzResourceGroupDeployment -Resourcegroupname $prefix -TemplateFile .\Webapp-template.json -Name "DemoWebSite" -TemplateParameterObject $parameters