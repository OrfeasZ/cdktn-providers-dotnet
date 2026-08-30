using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesTarget), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesTarget")]
    public interface IDomainDevicesInterfacesTarget
    {
        /// <summary>Sets the target device name for the interface (for example, "vnet0" or "tap0") that will be created or used on the host.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#overriding-the-target-element">https://libvirt.org/formatdomain.html#overriding-the-target-element</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}
        /// </remarks>
        [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
        string Dev
        {
            get;
        }

        /// <summary>Controls whether libvirt manages the lifecycle of the target device; boolean is encoded as "yes" or "no" in XML.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#generic-ethernet-connection">https://libvirt.org/formatdomain.html#generic-ethernet-connection</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#managed Domain#managed}
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

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesTarget), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesTarget")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the target device name for the interface (for example, "vnet0" or "tap0") that will be created or used on the host.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#overriding-the-target-element">https://libvirt.org/formatdomain.html#overriding-the-target-element</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#dev Domain#dev}
            /// </remarks>
            [JsiiProperty(name: "dev", typeJson: "{\"primitive\":\"string\"}")]
            public string Dev
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Controls whether libvirt manages the lifecycle of the target device; boolean is encoded as "yes" or "no" in XML.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#generic-ethernet-connection">https://libvirt.org/formatdomain.html#generic-ethernet-connection</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#managed Domain#managed}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Managed
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
