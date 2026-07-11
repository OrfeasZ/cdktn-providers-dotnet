using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepositorySshAuth")]
    public class SpringCloudServiceConfigServerGitSettingRepositorySshAuth : azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositorySshAuth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/spring_cloud_service#private_key SpringCloudService#private_key}.</summary>
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}")]
        public string PrivateKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/spring_cloud_service#host_key SpringCloudService#host_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/spring_cloud_service#host_key_algorithm SpringCloudService#host_key_algorithm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostKeyAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostKeyAlgorithm
        {
            get;
            set;
        }

        private object? _strictHostKeyCheckingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/spring_cloud_service#strict_host_key_checking_enabled SpringCloudService#strict_host_key_checking_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "strictHostKeyCheckingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? StrictHostKeyCheckingEnabled
        {
            get => _strictHostKeyCheckingEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _strictHostKeyCheckingEnabled = value;
            }
        }
    }
}
