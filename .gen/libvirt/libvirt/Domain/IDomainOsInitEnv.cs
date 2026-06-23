using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainOsInitEnv), fullyQualifiedName: "libvirt.domain.DomainOsInitEnv")]
    public interface IDomainOsInitEnv
    {
        /// <summary>Sets the environment variable name for a container init environment entry (for example "PATH" or "HTTP_PROXY").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Sets the environment variable value for a container init environment entry (for example "/usr/bin:/bin" or "http://proxy:8080").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#value Domain#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainOsInitEnv), fullyQualifiedName: "libvirt.domain.DomainOsInitEnv")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainOsInitEnv
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the environment variable name for a container init environment entry (for example "PATH" or "HTTP_PROXY").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the environment variable value for a container init environment entry (for example "/usr/bin:/bin" or "http://proxy:8080").</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#value Domain#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
