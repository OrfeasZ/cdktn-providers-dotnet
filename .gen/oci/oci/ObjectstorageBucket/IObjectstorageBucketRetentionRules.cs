using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ObjectstorageBucket
{
    [JsiiInterface(nativeType: typeof(IObjectstorageBucketRetentionRules), fullyQualifiedName: "oci.objectstorageBucket.ObjectstorageBucketRetentionRules")]
    public interface IObjectstorageBucketRetentionRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_bucket#display_name ObjectstorageBucket#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>duration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_bucket#duration ObjectstorageBucket#duration}
        /// </remarks>
        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"oci.objectstorageBucket.ObjectstorageBucketRetentionRulesDuration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ObjectstorageBucket.IObjectstorageBucketRetentionRulesDuration? Duration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_bucket#time_rule_locked ObjectstorageBucket#time_rule_locked}.</summary>
        [JsiiProperty(name: "timeRuleLocked", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeRuleLocked
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectstorageBucketRetentionRules), fullyQualifiedName: "oci.objectstorageBucket.ObjectstorageBucketRetentionRules")]
        internal sealed class _Proxy : DeputyBase, oci.ObjectstorageBucket.IObjectstorageBucketRetentionRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_bucket#display_name ObjectstorageBucket#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>duration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_bucket#duration ObjectstorageBucket#duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"oci.objectstorageBucket.ObjectstorageBucketRetentionRulesDuration\"}", isOptional: true)]
            public oci.ObjectstorageBucket.IObjectstorageBucketRetentionRulesDuration? Duration
            {
                get => GetInstanceProperty<oci.ObjectstorageBucket.IObjectstorageBucketRetentionRulesDuration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_bucket#time_rule_locked ObjectstorageBucket#time_rule_locked}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeRuleLocked", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeRuleLocked
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
