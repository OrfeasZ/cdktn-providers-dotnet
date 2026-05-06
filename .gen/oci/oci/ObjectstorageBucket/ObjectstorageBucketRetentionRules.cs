using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ObjectstorageBucket
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.objectstorageBucket.ObjectstorageBucketRetentionRules")]
    public class ObjectstorageBucketRetentionRules : oci.ObjectstorageBucket.IObjectstorageBucketRetentionRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_bucket#display_name ObjectstorageBucket#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>duration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_bucket#duration ObjectstorageBucket#duration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"oci.objectstorageBucket.ObjectstorageBucketRetentionRulesDuration\"}", isOptional: true)]
        public oci.ObjectstorageBucket.IObjectstorageBucketRetentionRulesDuration? Duration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_bucket#time_rule_locked ObjectstorageBucket#time_rule_locked}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeRuleLocked", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeRuleLocked
        {
            get;
            set;
        }
    }
}
