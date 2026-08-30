using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainBhyveCommandline")]
    public class DomainBhyveCommandline : libvirt.Domain.IDomainBhyveCommandline
    {
        private object? _args;

        /// <summary>Lists additional bhyve command-line arguments to append in order when starting the domain.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/drvbhyve.html">https://libvirt.org/drvbhyve.html</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#args Domain#args}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainBhyveCommandlineArgs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "args", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainBhyveCommandlineArgs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainBhyveCommandlineArgs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainBhyveCommandlineArgs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _args = value;
            }
        }

        private object? _envs;

        /// <summary>Lists environment variables to provide to the bhyve process when starting the domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#envs Domain#envs}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainBhyveCommandlineEnvs" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "envs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainBhyveCommandlineEnvs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainBhyveCommandlineEnvs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainBhyveCommandlineEnvs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _envs = value;
            }
        }
    }
}
