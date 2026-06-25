using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainKeyWrap")]
    public class DomainKeyWrap : libvirt.Domain.IDomainKeyWrap
    {
        private object? _ciphers;

        /// <summary>Defines one or more ciphers that can be used for s390 key-wrapping operations, each with its own name and enable/disable state.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#key-wrap">https://libvirt.org/formatdomain.html#key-wrap</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#ciphers Domain#ciphers}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainKeyWrapCiphers" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ciphers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainKeyWrapCiphers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ciphers
        {
            get => _ciphers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainKeyWrapCiphers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainKeyWrapCiphers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ciphers = value;
            }
        }
    }
}
