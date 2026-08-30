using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesCryptoBackend), fullyQualifiedName: "libvirt.domain.DomainDevicesCryptoBackend")]
    public interface IDomainDevicesCryptoBackend
    {
        /// <summary>Enables the built-in backend for the crypto device when set;</summary>
        /// <remarks>
        /// this is a presence-only flag, so omitting or setting it to false leaves the element out.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#built_in Domain#built_in}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
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

        /// <summary>Enables the LKCF-based backend for the crypto device when set;</summary>
        /// <remarks>
        /// this is a presence-only flag, so omitting or setting it to false leaves the element out.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#lkcf Domain#lkcf}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "lkcf", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Lkcf
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the number of queues used by the crypto backend;</summary>
        /// <remarks>
        /// the value is a user-provided non-negative integer tuned for performance.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#queues Domain#queues}
        /// </remarks>
        [JsiiProperty(name: "queues", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Queues
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesCryptoBackend), fullyQualifiedName: "libvirt.domain.DomainDevicesCryptoBackend")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesCryptoBackend
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enables the built-in backend for the crypto device when set;</summary>
            /// <remarks>
            /// this is a presence-only flag, so omitting or setting it to false leaves the element out.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#built_in Domain#built_in}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "builtIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? BuiltIn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Enables the LKCF-based backend for the crypto device when set;</summary>
            /// <remarks>
            /// this is a presence-only flag, so omitting or setting it to false leaves the element out.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#lkcf Domain#lkcf}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lkcf", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Lkcf
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sets the number of queues used by the crypto backend;</summary>
            /// <remarks>
            /// the value is a user-provided non-negative integer tuned for performance.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#crypto">https://libvirt.org/formatdomain.html#crypto</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#queues Domain#queues}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queues", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Queues
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
