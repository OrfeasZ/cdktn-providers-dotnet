using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MarketplacePublication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.marketplacePublication.MarketplacePublicationPackageDetails")]
    public class MarketplacePublicationPackageDetails : oci.MarketplacePublication.IMarketplacePublicationPackageDetails
    {
        private object _eula;

        /// <summary>eula block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#eula MarketplacePublication#eula}
        /// </remarks>
        [JsiiProperty(name: "eula", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.marketplacePublication.MarketplacePublicationPackageDetailsEula\"},\"kind\":\"array\"}}]}}")]
        public object Eula
        {
            get => _eula;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.MarketplacePublication.IMarketplacePublicationPackageDetailsEula[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MarketplacePublication.IMarketplacePublicationPackageDetailsEula).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.MarketplacePublication.IMarketplacePublicationPackageDetailsEula).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _eula = value;
            }
        }

        /// <summary>operating_system block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#operating_system MarketplacePublication#operating_system}
        /// </remarks>
        [JsiiProperty(name: "operatingSystem", typeJson: "{\"fqn\":\"oci.marketplacePublication.MarketplacePublicationPackageDetailsOperatingSystem\"}")]
        public oci.MarketplacePublication.IMarketplacePublicationPackageDetailsOperatingSystem OperatingSystem
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#package_type MarketplacePublication#package_type}.</summary>
        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        public string PackageType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#package_version MarketplacePublication#package_version}.</summary>
        [JsiiProperty(name: "packageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string PackageVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/marketplace_publication#image_id MarketplacePublication#image_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageId
        {
            get;
            set;
        }
    }
}
