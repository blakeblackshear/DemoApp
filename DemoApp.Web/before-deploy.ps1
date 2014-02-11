Write-Host "This is a message from before-deploy script"

if(Enter-OncePerDeployment "test1")
{
    Write-Host "This block is being run once per deployment, per cluster!"
}