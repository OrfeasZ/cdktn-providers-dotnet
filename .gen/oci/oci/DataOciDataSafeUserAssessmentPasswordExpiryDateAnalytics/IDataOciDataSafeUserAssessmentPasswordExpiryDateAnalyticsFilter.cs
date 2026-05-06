using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics
{
    [JsiiInterface(nativeType: typeof(IDataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsFilter), fullyQualifiedName: "oci.dataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsFilter")]
    public interface IDataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_password_expiry_date_analytics#name DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_password_expiry_date_analytics#values DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_password_expiry_date_analytics#regex DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsFilter), fullyQualifiedName: "oci.dataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics.IDataOciDataSafeUserAssessmentPasswordExpiryDateAnalyticsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_password_expiry_date_analytics#name DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_password_expiry_date_analytics#values DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/data_safe_user_assessment_password_expiry_date_analytics#regex DataOciDataSafeUserAssessmentPasswordExpiryDateAnalytics#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
