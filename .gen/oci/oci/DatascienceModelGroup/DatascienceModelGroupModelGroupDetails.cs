using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceModelGroup.DatascienceModelGroupModelGroupDetails")]
    public class DatascienceModelGroupModelGroupDetails : oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#type DatascienceModelGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#base_model_id DatascienceModelGroup#base_model_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "baseModelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BaseModelId
        {
            get;
            set;
        }

        private object? _customMetadataList;

        /// <summary>custom_metadata_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#custom_metadata_list DatascienceModelGroup#custom_metadata_list}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customMetadataList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupModelGroupDetailsCustomMetadataListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomMetadataList
        {
            get => _customMetadataList;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupDetailsCustomMetadataListStruct[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceModelGroup.IDatascienceModelGroupModelGroupDetailsCustomMetadataListStruct).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customMetadataList = value;
            }
        }
    }
}
