using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiInterface(nativeType: typeof(IPoolSourceAdapter), fullyQualifiedName: "libvirt.pool.PoolSourceAdapter")]
    public interface IPoolSourceAdapter
    {
        /// <summary>Controls whether libvirt manages the adapter’s login/session; accepts "yes" or "no" and is interpreted as a boolean.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#managed Pool#managed}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "managed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Managed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the adapter name for the pool source, typically the host HBA or interface identifier (user-provided string, such as "host0").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#name Pool#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets an optional parent adapter identifier if the specified adapter is a child of another adapter (user-provided string).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#parent Pool#parent}
        /// </remarks>
        [JsiiProperty(name: "parent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Parent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the PCI-style address and unique ID of the parent adapter for the storage pool source.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#parent_addr Pool#parent_addr}
        /// </remarks>
        [JsiiProperty(name: "parentAddr", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceAdapterParentAddr\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Pool.IPoolSourceAdapterParentAddr? ParentAddr
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the adapter type for the pool source (e.g., HBA type); value is user-provided and must be supported by the chosen pool backend.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#type Pool#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the World Wide Node Name (WWNN) for a Fibre Channel adapter;</summary>
        /// <remarks>
        /// value is a user-provided FC WWN string (e.g., "5005076802401234").
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#wwnn Pool#wwnn}
        /// </remarks>
        [JsiiProperty(name: "wwnn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Wwnn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the World Wide Port Name (WWPN) for a Fibre Channel adapter;</summary>
        /// <remarks>
        /// value is a user-provided FC WWN string (e.g., "5005076802456789").
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#wwpn Pool#wwpn}
        /// </remarks>
        [JsiiProperty(name: "wwpn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Wwpn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPoolSourceAdapter), fullyQualifiedName: "libvirt.pool.PoolSourceAdapter")]
        internal sealed class _Proxy : DeputyBase, libvirt.Pool.IPoolSourceAdapter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether libvirt manages the adapter’s login/session; accepts "yes" or "no" and is interpreted as a boolean.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#managed Pool#managed}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Managed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the adapter name for the pool source, typically the host HBA or interface identifier (user-provided string, such as "host0").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#name Pool#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets an optional parent adapter identifier if the specified adapter is a child of another adapter (user-provided string).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#parent Pool#parent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Parent
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures the PCI-style address and unique ID of the parent adapter for the storage pool source.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#parent_addr Pool#parent_addr}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parentAddr", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceAdapterParentAddr\"}", isOptional: true)]
            public libvirt.Pool.IPoolSourceAdapterParentAddr? ParentAddr
            {
                get => GetInstanceProperty<libvirt.Pool.IPoolSourceAdapterParentAddr?>();
            }

            /// <summary>Sets the adapter type for the pool source (e.g., HBA type); value is user-provided and must be supported by the chosen pool backend.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#type Pool#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the World Wide Node Name (WWNN) for a Fibre Channel adapter;</summary>
            /// <remarks>
            /// value is a user-provided FC WWN string (e.g., "5005076802401234").
            ///
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#wwnn Pool#wwnn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wwnn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Wwnn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the World Wide Port Name (WWPN) for a Fibre Channel adapter;</summary>
            /// <remarks>
            /// value is a user-provided FC WWN string (e.g., "5005076802456789").
            ///
            /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#wwpn Pool#wwpn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wwpn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Wwpn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
