using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeUnsetSecurityAssessmentBaselineManagement
{
    [JsiiInterface(nativeType: typeof(IDataSafeUnsetSecurityAssessmentBaselineManagementTimeouts), fullyQualifiedName: "oci.dataSafeUnsetSecurityAssessmentBaselineManagement.DataSafeUnsetSecurityAssessmentBaselineManagementTimeouts")]
    public interface IDataSafeUnsetSecurityAssessmentBaselineManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unset_security_assessment_baseline_management#create DataSafeUnsetSecurityAssessmentBaselineManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unset_security_assessment_baseline_management#delete DataSafeUnsetSecurityAssessmentBaselineManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unset_security_assessment_baseline_management#update DataSafeUnsetSecurityAssessmentBaselineManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeUnsetSecurityAssessmentBaselineManagementTimeouts), fullyQualifiedName: "oci.dataSafeUnsetSecurityAssessmentBaselineManagement.DataSafeUnsetSecurityAssessmentBaselineManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeUnsetSecurityAssessmentBaselineManagement.IDataSafeUnsetSecurityAssessmentBaselineManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unset_security_assessment_baseline_management#create DataSafeUnsetSecurityAssessmentBaselineManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unset_security_assessment_baseline_management#delete DataSafeUnsetSecurityAssessmentBaselineManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unset_security_assessment_baseline_management#update DataSafeUnsetSecurityAssessmentBaselineManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
