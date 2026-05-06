using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSetSecurityAssessmentBaseline
{
    [JsiiInterface(nativeType: typeof(IDataSafeSetSecurityAssessmentBaselineTimeouts), fullyQualifiedName: "oci.dataSafeSetSecurityAssessmentBaseline.DataSafeSetSecurityAssessmentBaselineTimeouts")]
    public interface IDataSafeSetSecurityAssessmentBaselineTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_set_security_assessment_baseline#create DataSafeSetSecurityAssessmentBaseline#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_set_security_assessment_baseline#delete DataSafeSetSecurityAssessmentBaseline#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_set_security_assessment_baseline#update DataSafeSetSecurityAssessmentBaseline#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSetSecurityAssessmentBaselineTimeouts), fullyQualifiedName: "oci.dataSafeSetSecurityAssessmentBaseline.DataSafeSetSecurityAssessmentBaselineTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSetSecurityAssessmentBaseline.IDataSafeSetSecurityAssessmentBaselineTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_set_security_assessment_baseline#create DataSafeSetSecurityAssessmentBaseline#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_set_security_assessment_baseline#delete DataSafeSetSecurityAssessmentBaseline#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_set_security_assessment_baseline#update DataSafeSetSecurityAssessmentBaseline#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
