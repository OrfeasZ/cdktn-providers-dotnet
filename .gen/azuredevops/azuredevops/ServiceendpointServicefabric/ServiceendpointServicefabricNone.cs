using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointServicefabric
{
    [JsiiByValue(fqn: "azuredevops.serviceendpointServicefabric.ServiceendpointServicefabricNone")]
    public class ServiceendpointServicefabricNone : azuredevops.ServiceendpointServicefabric.IServiceendpointServicefabricNone
    {
        /// <summary>Fully qualified domain SPN for gMSA account. This is applicable only if `unsecured` option is disabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#cluster_spn ServiceendpointServicefabric#cluster_spn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterSpn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterSpn
        {
            get;
            set;
        }

        private object? _unsecured;

        /// <summary>Skip using windows security for authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_servicefabric#unsecured ServiceendpointServicefabric#unsecured}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unsecured", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Unsecured
        {
            get => _unsecured;
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
                _unsecured = value;
            }
        }
    }
}
