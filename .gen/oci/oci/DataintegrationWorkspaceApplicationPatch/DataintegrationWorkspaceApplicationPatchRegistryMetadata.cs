using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplicationPatch
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceApplicationPatch.DataintegrationWorkspaceApplicationPatchRegistryMetadata")]
    public class DataintegrationWorkspaceApplicationPatchRegistryMetadata : oci.DataintegrationWorkspaceApplicationPatch.IDataintegrationWorkspaceApplicationPatchRegistryMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_patch#aggregator_key DataintegrationWorkspaceApplicationPatch#aggregator_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aggregatorKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AggregatorKey
        {
            get;
            set;
        }

        private object? _isFavorite;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_patch#is_favorite DataintegrationWorkspaceApplicationPatch#is_favorite}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isFavorite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsFavorite
        {
            get => _isFavorite;
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
                _isFavorite = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_patch#key DataintegrationWorkspaceApplicationPatch#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_patch#labels DataintegrationWorkspaceApplicationPatch#labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Labels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_patch#registry_version DataintegrationWorkspaceApplicationPatch#registry_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "registryVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RegistryVersion
        {
            get;
            set;
        }
    }
}
