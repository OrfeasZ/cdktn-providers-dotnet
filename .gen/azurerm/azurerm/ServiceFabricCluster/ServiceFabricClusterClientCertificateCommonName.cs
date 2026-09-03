using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.serviceFabricCluster.ServiceFabricClusterClientCertificateCommonName")]
    public class ServiceFabricClusterClientCertificateCommonName : azurerm.ServiceFabricCluster.IServiceFabricClusterClientCertificateCommonName
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/service_fabric_cluster#common_name ServiceFabricCluster#common_name}.</summary>
        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
        public string CommonName
        {
            get;
            set;
        }

        private object _isAdmin;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/service_fabric_cluster#is_admin ServiceFabricCluster#is_admin}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isAdmin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsAdmin
        {
            get => _isAdmin;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isAdmin = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/service_fabric_cluster#issuer_thumbprint ServiceFabricCluster#issuer_thumbprint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "issuerThumbprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IssuerThumbprint
        {
            get;
            set;
        }
    }
}
