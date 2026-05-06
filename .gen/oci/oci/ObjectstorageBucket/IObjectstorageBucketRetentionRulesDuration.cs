using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ObjectstorageBucket
{
    [JsiiInterface(nativeType: typeof(IObjectstorageBucketRetentionRulesDuration), fullyQualifiedName: "oci.objectstorageBucket.ObjectstorageBucketRetentionRulesDuration")]
    public interface IObjectstorageBucketRetentionRulesDuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_bucket#time_amount ObjectstorageBucket#time_amount}.</summary>
        [JsiiProperty(name: "timeAmount", typeJson: "{\"primitive\":\"string\"}")]
        string TimeAmount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_bucket#time_unit ObjectstorageBucket#time_unit}.</summary>
        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
        string TimeUnit
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectstorageBucketRetentionRulesDuration), fullyQualifiedName: "oci.objectstorageBucket.ObjectstorageBucketRetentionRulesDuration")]
        internal sealed class _Proxy : DeputyBase, oci.ObjectstorageBucket.IObjectstorageBucketRetentionRulesDuration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_bucket#time_amount ObjectstorageBucket#time_amount}.</summary>
            [JsiiProperty(name: "timeAmount", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeAmount
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_bucket#time_unit ObjectstorageBucket#time_unit}.</summary>
            [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeUnit
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
