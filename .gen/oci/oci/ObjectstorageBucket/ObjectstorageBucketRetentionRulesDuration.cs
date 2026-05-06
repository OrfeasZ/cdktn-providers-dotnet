using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ObjectstorageBucket
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.objectstorageBucket.ObjectstorageBucketRetentionRulesDuration")]
    public class ObjectstorageBucketRetentionRulesDuration : oci.ObjectstorageBucket.IObjectstorageBucketRetentionRulesDuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_bucket#time_amount ObjectstorageBucket#time_amount}.</summary>
        [JsiiProperty(name: "timeAmount", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeAmount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_bucket#time_unit ObjectstorageBucket#time_unit}.</summary>
        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeUnit
        {
            get;
            set;
        }
    }
}
