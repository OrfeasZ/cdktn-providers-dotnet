using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSensitiveTypeGroupGroupedSensitiveType
{
    [JsiiInterface(nativeType: typeof(IDataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations), fullyQualifiedName: "oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations")]
    public interface IDataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#operation DataSafeSensitiveTypeGroupGroupedSensitiveType#operation}.</summary>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        string Operation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#selection DataSafeSensitiveTypeGroupGroupedSensitiveType#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        string Selection
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#value DataSafeSensitiveTypeGroupGroupedSensitiveType#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations), fullyQualifiedName: "oci.dataSafeSensitiveTypeGroupGroupedSensitiveType.DataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSensitiveTypeGroupGroupedSensitiveType.IDataSafeSensitiveTypeGroupGroupedSensitiveTypePatchOperations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#operation DataSafeSensitiveTypeGroupGroupedSensitiveType#operation}.</summary>
            [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
            public string Operation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#selection DataSafeSensitiveTypeGroupGroupedSensitiveType#selection}.</summary>
            [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
            public string Selection
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_sensitive_type_group_grouped_sensitive_type#value DataSafeSensitiveTypeGroupGroupedSensitiveType#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> Value
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }
        }
    }
}
