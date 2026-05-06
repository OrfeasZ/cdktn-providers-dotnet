using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployment
{
    [JsiiByValue(fqn: "oci.devopsDeployment.DevopsDeploymentDeployStageOverrideArguments")]
    public class DevopsDeploymentDeployStageOverrideArguments : oci.DevopsDeployment.IDevopsDeploymentDeployStageOverrideArguments
    {
        private object? _items;

        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deployment#items DevopsDeployment#items}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsDeployment.DevopsDeploymentDeployStageOverrideArgumentsItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Items
        {
            get => _items;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DevopsDeployment.IDevopsDeploymentDeployStageOverrideArgumentsItems[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DevopsDeployment.IDevopsDeploymentDeployStageOverrideArgumentsItems).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _items = value;
            }
        }
    }
}
