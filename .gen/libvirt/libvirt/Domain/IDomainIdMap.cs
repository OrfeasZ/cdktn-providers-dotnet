using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainIdMap), fullyQualifiedName: "libvirt.domain.DomainIdMap")]
    public interface IDomainIdMap
    {
        /// <summary>Defines one or more guest-to-host GID mapping ranges used for ID translation; each entry specifies a contiguous gid range.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gi_ds Domain#gi_ds}
        /// </remarks>
        [JsiiProperty(name: "giDs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainIdMapGiDs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GiDs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines one or more guest-to-host UID mapping ranges used for ID translation; each entry specifies a contiguous uid range.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ui_ds Domain#ui_ds}
        /// </remarks>
        [JsiiProperty(name: "uiDs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainIdMapUiDs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UiDs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainIdMap), fullyQualifiedName: "libvirt.domain.DomainIdMap")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainIdMap
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines one or more guest-to-host GID mapping ranges used for ID translation; each entry specifies a contiguous gid range.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gi_ds Domain#gi_ds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "giDs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainIdMapGiDs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GiDs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines one or more guest-to-host UID mapping ranges used for ID translation; each entry specifies a contiguous uid range.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ui_ds Domain#ui_ds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uiDs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainIdMapUiDs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UiDs
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
