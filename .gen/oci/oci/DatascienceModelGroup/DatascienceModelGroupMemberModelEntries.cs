using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelGroup
{
    [JsiiByValue(fqn: "oci.datascienceModelGroup.DatascienceModelGroupMemberModelEntries")]
    public class DatascienceModelGroupMemberModelEntries : oci.DatascienceModelGroup.IDatascienceModelGroupMemberModelEntries
    {
        private object? _memberModelDetails;

        /// <summary>member_model_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_group#member_model_details DatascienceModelGroup#member_model_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memberModelDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceModelGroup.DatascienceModelGroupMemberModelEntriesMemberModelDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MemberModelDetails
        {
            get => _memberModelDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatascienceModelGroup.IDatascienceModelGroupMemberModelEntriesMemberModelDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceModelGroup.IDatascienceModelGroupMemberModelEntriesMemberModelDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _memberModelDetails = value;
            }
        }
    }
}
