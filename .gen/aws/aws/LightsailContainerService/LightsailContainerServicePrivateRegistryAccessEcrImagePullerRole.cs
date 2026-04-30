using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailContainerService
{
    [JsiiByValue(fqn: "aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccessEcrImagePullerRole")]
    public class LightsailContainerServicePrivateRegistryAccessEcrImagePullerRole : aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccessEcrImagePullerRole
    {
        private object? _isActive;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lightsail_container_service#is_active LightsailContainerService#is_active}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isActive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsActive
        {
            get => _isActive;
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
                _isActive = value;
            }
        }
    }
}
