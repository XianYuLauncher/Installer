namespace XianYuLauncher_installer.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
