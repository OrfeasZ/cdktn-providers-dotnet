using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiInterface(nativeType: typeof(IDifStackOkeComponentValueOverrides), fullyQualifiedName: "oci.difStack.DifStackOkeComponentValueOverrides")]
    public interface IDifStackOkeComponentValueOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#component_name DifStack#component_name}.</summary>
        [JsiiProperty(name: "componentName", typeJson: "{\"primitive\":\"string\"}")]
        string ComponentName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#value_overrides DifStack#value_overrides}.</summary>
        [JsiiProperty(name: "valueOverrides", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> ValueOverrides
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDifStackOkeComponentValueOverrides), fullyQualifiedName: "oci.difStack.DifStackOkeComponentValueOverrides")]
        internal sealed class _Proxy : DeputyBase, oci.DifStack.IDifStackOkeComponentValueOverrides
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#component_name DifStack#component_name}.</summary>
            [JsiiProperty(name: "componentName", typeJson: "{\"primitive\":\"string\"}")]
            public string ComponentName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/dif_stack#value_overrides DifStack#value_overrides}.</summary>
            [JsiiProperty(name: "valueOverrides", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> ValueOverrides
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }
        }
    }
}
