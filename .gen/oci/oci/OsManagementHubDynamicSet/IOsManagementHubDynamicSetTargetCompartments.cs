using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubDynamicSet
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubDynamicSetTargetCompartments), fullyQualifiedName: "oci.osManagementHubDynamicSet.OsManagementHubDynamicSetTargetCompartments")]
    public interface IOsManagementHubDynamicSetTargetCompartments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_dynamic_set#compartment_id OsManagementHubDynamicSet#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_dynamic_set#does_include_children OsManagementHubDynamicSet#does_include_children}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "doesIncludeChildren", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object DoesIncludeChildren
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubDynamicSetTargetCompartments), fullyQualifiedName: "oci.osManagementHubDynamicSet.OsManagementHubDynamicSetTargetCompartments")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubDynamicSet.IOsManagementHubDynamicSetTargetCompartments
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_dynamic_set#compartment_id OsManagementHubDynamicSet#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/os_management_hub_dynamic_set#does_include_children OsManagementHubDynamicSet#does_include_children}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "doesIncludeChildren", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object DoesIncludeChildren
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
