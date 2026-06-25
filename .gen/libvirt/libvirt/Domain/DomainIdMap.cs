using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainIdMap")]
    public class DomainIdMap : libvirt.Domain.IDomainIdMap
    {
        private object? _giDs;

        /// <summary>Defines one or more guest-to-host GID mapping ranges used for ID translation; each entry specifies a contiguous gid range.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#gi_ds Domain#gi_ds}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainIdMapGiDs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "giDs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainIdMapGiDs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GiDs
        {
            get => _giDs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainIdMapGiDs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainIdMapGiDs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _giDs = value;
            }
        }

        private object? _uiDs;

        /// <summary>Defines one or more guest-to-host UID mapping ranges used for ID translation; each entry specifies a contiguous uid range.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#container-boot">https://libvirt.org/formatdomain.html#container-boot</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ui_ds Domain#ui_ds}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainIdMapUiDs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uiDs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainIdMapUiDs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UiDs
        {
            get => _uiDs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainIdMapUiDs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainIdMapUiDs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _uiDs = value;
            }
        }
    }
}
