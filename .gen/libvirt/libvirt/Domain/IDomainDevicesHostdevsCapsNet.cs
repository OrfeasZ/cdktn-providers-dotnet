using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsCapsNet), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsCapsNet")]
    public interface IDomainDevicesHostdevsCapsNet
    {
        /// <summary>Configures one or more IP addresses associated with the passthrough network host device, including address, family, and prefix.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ip Domain#ip}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesHostdevsCapsNetIp" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsNetIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines a static route reachable via the passthrough network host device, including destination address, family, and gateway.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#route Domain#route}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesHostdevsCapsNetRoute" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "route", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsNetRoute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Route
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the source information for the passthrough network host device, such as the backing host interface.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsNetSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesHostdevsCapsNetSource? Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsCapsNet), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsCapsNet")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsCapsNet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures one or more IP addresses associated with the passthrough network host device, including address, family, and prefix.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#ip Domain#ip}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesHostdevsCapsNetIp" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsNetIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ip
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines a static route reachable via the passthrough network host device, including destination address, family, and gateway.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#ip-configuration">https://libvirt.org/formatdomain.html#ip-configuration</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#route Domain#route}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesHostdevsCapsNetRoute" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "route", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsNetRoute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Route
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures the source information for the passthrough network host device, such as the backing host interface.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesHostdevsCapsNetSource\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesHostdevsCapsNetSource? Source
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesHostdevsCapsNetSource?>();
            }
        }
    }
}
