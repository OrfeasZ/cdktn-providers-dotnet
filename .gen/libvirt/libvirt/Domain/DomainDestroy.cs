using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDestroy")]
    public class DomainDestroy : libvirt.Domain.IDomainDestroy
    {
        private object? _graceful;

        /// <summary>Experimental: request graceful behavior when using DomainDestroyFlags during domain stop. Subject to change in future releases.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#graceful Domain#graceful}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "graceful", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Graceful
        {
            get => _graceful;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _graceful = value;
            }
        }

        /// <summary>Experimental: request a guest shutdown and wait for shutoff before undefine. Subject to change in future releases.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#shutdown Domain#shutdown}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shutdown", typeJson: "{\"fqn\":\"libvirt.domain.DomainDestroyShutdown\"}", isOptional: true)]
        public libvirt.Domain.IDomainDestroyShutdown? Shutdown
        {
            get;
            set;
        }
    }
}
