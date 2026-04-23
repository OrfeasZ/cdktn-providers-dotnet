using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    [JsiiByValue(fqn: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationIdentityCenterConfiguration")]
    public class AthenaWorkgroupConfigurationIdentityCenterConfiguration : aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationIdentityCenterConfiguration
    {
        private object? _enableIdentityCenter;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#enable_identity_center AthenaWorkgroup#enable_identity_center}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableIdentityCenter", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableIdentityCenter
        {
            get => _enableIdentityCenter;
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
                _enableIdentityCenter = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/athena_workgroup#identity_center_instance_arn AthenaWorkgroup#identity_center_instance_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityCenterInstanceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentityCenterInstanceArn
        {
            get;
            set;
        }
    }
}
