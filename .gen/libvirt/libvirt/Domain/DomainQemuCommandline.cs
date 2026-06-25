using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainQemuCommandline")]
    public class DomainQemuCommandline : libvirt.Domain.IDomainQemuCommandline
    {
        private object? _args;

        /// <summary>Lists additional QEMU command-line arguments to append in order;</summary>
        /// <remarks>
        /// each item represents one argument token rather than a shell-joined string.
        ///
        /// See: <a href="https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions">https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#args Domain#args}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuCommandlineArgs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "args", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuCommandlineArgs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Args
        {
            get => _args;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainQemuCommandlineArgs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainQemuCommandlineArgs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _args = value;
            }
        }

        private object? _envs;

        /// <summary>Lists environment variables to expose to the QEMU process when starting the domain.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions">https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#envs Domain#envs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuCommandlineEnvs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "envs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuCommandlineEnvs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Envs
        {
            get => _envs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainQemuCommandlineEnvs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainQemuCommandlineEnvs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _envs = value;
            }
        }
    }
}
