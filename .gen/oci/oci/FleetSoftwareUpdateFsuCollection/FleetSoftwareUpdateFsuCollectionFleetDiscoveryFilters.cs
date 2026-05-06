using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetSoftwareUpdateFsuCollection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionFleetDiscoveryFilters")]
    public class FleetSoftwareUpdateFsuCollectionFleetDiscoveryFilters : oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionFleetDiscoveryFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#type FleetSoftwareUpdateFsuCollection#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#entity_type FleetSoftwareUpdateFsuCollection#entity_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EntityType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#exadata_releases FleetSoftwareUpdateFsuCollection#exadata_releases}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exadataReleases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExadataReleases
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#identifiers FleetSoftwareUpdateFsuCollection#identifiers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Identifiers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#mode FleetSoftwareUpdateFsuCollection#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#names FleetSoftwareUpdateFsuCollection#names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "names", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Names
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#operator FleetSoftwareUpdateFsuCollection#operator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Operator
        {
            get;
            set;
        }

        private object? _tags;

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#tags FleetSoftwareUpdateFsuCollection#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetSoftwareUpdateFsuCollection.FleetSoftwareUpdateFsuCollectionFleetDiscoveryFiltersTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Tags
        {
            get => _tags;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionFleetDiscoveryFiltersTags[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetSoftwareUpdateFsuCollection.IFleetSoftwareUpdateFsuCollectionFleetDiscoveryFiltersTags).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tags = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_software_update_fsu_collection#versions FleetSoftwareUpdateFsuCollection#versions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "versions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Versions
        {
            get;
            set;
        }
    }
}
