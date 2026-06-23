using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesRngsBackend), fullyQualifiedName: "libvirt.domain.DomainDevicesRngsBackend")]
    public interface IDomainDevicesRngsBackend
    {
        /// <summary>Enables use of the hypervisor’s built-in RNG backend when set (presence-only);</summary>
        /// <remarks>
        /// omit this field to avoid configuring a built-in backend.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#built_in Domain#built_in}
        /// </remarks>
        [JsiiProperty(name: "builtIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BuiltIn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures an external entropy gathering daemon (EGD) as the RNG backend, including protocol and source details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#egd Domain#egd}
        /// </remarks>
        [JsiiProperty(name: "egd", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsBackendEgd\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesRngsBackendEgd? Egd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects the host random backend for the RNG device, typically mapping to a host RNG source such as /dev/random or /dev/urandom;</summary>
        /// <remarks>
        /// details are user-provided.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#random Domain#random}
        /// </remarks>
        [JsiiProperty(name: "random", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Random
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesRngsBackend), fullyQualifiedName: "libvirt.domain.DomainDevicesRngsBackend")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesRngsBackend
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enables use of the hypervisor’s built-in RNG backend when set (presence-only);</summary>
            /// <remarks>
            /// omit this field to avoid configuring a built-in backend.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#built_in Domain#built_in}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "builtIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? BuiltIn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configures an external entropy gathering daemon (EGD) as the RNG backend, including protocol and source details.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#egd Domain#egd}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "egd", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesRngsBackendEgd\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesRngsBackendEgd? Egd
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesRngsBackendEgd?>();
            }

            /// <summary>Selects the host random backend for the RNG device, typically mapping to a host RNG source such as /dev/random or /dev/urandom;</summary>
            /// <remarks>
            /// details are user-provided.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#random Domain#random}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "random", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Random
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
