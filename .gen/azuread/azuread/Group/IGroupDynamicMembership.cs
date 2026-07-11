using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Group
{
    [JsiiInterface(nativeType: typeof(IGroupDynamicMembership), fullyQualifiedName: "azuread.group.GroupDynamicMembership")]
    public interface IGroupDynamicMembership
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group#enabled Group#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Rule to determine members for a dynamic group. Required when `group_types` contains 'DynamicMembership'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group#rule Group#rule}
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
        string Rule
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGroupDynamicMembership), fullyQualifiedName: "azuread.group.GroupDynamicMembership")]
        internal sealed class _Proxy : DeputyBase, azuread.Group.IGroupDynamicMembership
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group#enabled Group#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Rule to determine members for a dynamic group. Required when `group_types` contains 'DynamicMembership'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group#rule Group#rule}
            /// </remarks>
            [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
            public string Rule
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
