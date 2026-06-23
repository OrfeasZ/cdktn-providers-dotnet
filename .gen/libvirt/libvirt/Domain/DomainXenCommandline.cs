using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainXenCommandline")]
    public class DomainXenCommandline : libvirt.Domain.IDomainXenCommandline
    {
        private object? _args;

        /// <summary>Lists additional command-line arguments to pass to the Xen qemu device model in order.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/drvxen.html">https://libvirt.org/drvxen.html</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#args Domain#args}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "args", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainXenCommandlineArgs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case libvirt.Domain.IDomainXenCommandlineArgs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainXenCommandlineArgs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _args = value;
            }
        }
    }
}
