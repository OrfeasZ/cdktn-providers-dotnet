using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointKubernetes
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointKubernetes.ServiceendpointKubernetesServiceAccount")]
    public class ServiceendpointKubernetesServiceAccount : azuredevops.ServiceendpointKubernetes.IServiceendpointKubernetesServiceAccount
    {
        /// <summary>Secret cert.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#ca_cert ServiceendpointKubernetes#ca_cert}
        /// </remarks>
        [JsiiProperty(name: "caCert", typeJson: "{\"primitive\":\"string\"}")]
        public string CaCert
        {
            get;
            set;
        }

        /// <summary>Secret token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#token ServiceendpointKubernetes#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        public string Token
        {
            get;
            set;
        }

        private object? _acceptUntrustedCerts;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_kubernetes#accept_untrusted_certs ServiceendpointKubernetes#accept_untrusted_certs}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acceptUntrustedCerts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AcceptUntrustedCerts
        {
            get => _acceptUntrustedCerts;
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
                _acceptUntrustedCerts = value;
            }
        }
    }
}
