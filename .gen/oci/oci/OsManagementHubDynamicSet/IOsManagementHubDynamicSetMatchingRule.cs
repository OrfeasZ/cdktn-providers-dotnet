using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubDynamicSet
{
    [JsiiInterface(nativeType: typeof(IOsManagementHubDynamicSetMatchingRule), fullyQualifiedName: "oci.osManagementHubDynamicSet.OsManagementHubDynamicSetMatchingRule")]
    public interface IOsManagementHubDynamicSetMatchingRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#architectures OsManagementHubDynamicSet#architectures}.</summary>
        [JsiiProperty(name: "architectures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Architectures
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#display_names OsManagementHubDynamicSet#display_names}.</summary>
        [JsiiProperty(name: "displayNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DisplayNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#is_reboot_required OsManagementHubDynamicSet#is_reboot_required}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isRebootRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsRebootRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#locations OsManagementHubDynamicSet#locations}.</summary>
        [JsiiProperty(name: "locations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Locations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#managed_instance_group_ids OsManagementHubDynamicSet#managed_instance_group_ids}.</summary>
        [JsiiProperty(name: "managedInstanceGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ManagedInstanceGroupIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#managed_instance_ids OsManagementHubDynamicSet#managed_instance_ids}.</summary>
        [JsiiProperty(name: "managedInstanceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ManagedInstanceIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#os_families OsManagementHubDynamicSet#os_families}.</summary>
        [JsiiProperty(name: "osFamilies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OsFamilies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#os_names OsManagementHubDynamicSet#os_names}.</summary>
        [JsiiProperty(name: "osNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OsNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#statuses OsManagementHubDynamicSet#statuses}.</summary>
        [JsiiProperty(name: "statuses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Statuses
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#tags OsManagementHubDynamicSet#tags}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OsManagementHubDynamicSet.IOsManagementHubDynamicSetMatchingRuleTags" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubDynamicSet.OsManagementHubDynamicSetMatchingRuleTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOsManagementHubDynamicSetMatchingRule), fullyQualifiedName: "oci.osManagementHubDynamicSet.OsManagementHubDynamicSetMatchingRule")]
        internal sealed class _Proxy : DeputyBase, oci.OsManagementHubDynamicSet.IOsManagementHubDynamicSetMatchingRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#architectures OsManagementHubDynamicSet#architectures}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "architectures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Architectures
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#display_names OsManagementHubDynamicSet#display_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DisplayNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#is_reboot_required OsManagementHubDynamicSet#is_reboot_required}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isRebootRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsRebootRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#locations OsManagementHubDynamicSet#locations}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "locations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Locations
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#managed_instance_group_ids OsManagementHubDynamicSet#managed_instance_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedInstanceGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ManagedInstanceGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#managed_instance_ids OsManagementHubDynamicSet#managed_instance_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedInstanceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ManagedInstanceIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#os_families OsManagementHubDynamicSet#os_families}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "osFamilies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OsFamilies
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#os_names OsManagementHubDynamicSet#os_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "osNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OsNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#statuses OsManagementHubDynamicSet#statuses}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "statuses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Statuses
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/os_management_hub_dynamic_set#tags OsManagementHubDynamicSet#tags}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OsManagementHubDynamicSet.IOsManagementHubDynamicSetMatchingRuleTags" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.osManagementHubDynamicSet.OsManagementHubDynamicSetMatchingRuleTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
