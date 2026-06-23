using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainBhyveCommandline), fullyQualifiedName: "libvirt.domain.DomainBhyveCommandline")]
    public interface IDomainBhyveCommandline
    {
        /// <summary>Lists additional bhyve command-line arguments to append in order when starting the domain.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/drvbhyve.html">https://libvirt.org/drvbhyve.html</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#args Domain#args}
        /// </remarks>
        [JsiiProperty(name: "args", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainBhyveCommandlineArgs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Args
        {
            get
            {
                return null;
            }
        }

        /// <summary>Lists environment variables to provide to the bhyve process when starting the domain.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#envs Domain#envs}
        /// </remarks>
        [JsiiProperty(name: "envs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainBhyveCommandlineEnvs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Envs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainBhyveCommandline), fullyQualifiedName: "libvirt.domain.DomainBhyveCommandline")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainBhyveCommandline
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Lists additional bhyve command-line arguments to append in order when starting the domain.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/drvbhyve.html">https://libvirt.org/drvbhyve.html</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#args Domain#args}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "args", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainBhyveCommandlineArgs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Args
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Lists environment variables to provide to the bhyve process when starting the domain.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#envs Domain#envs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "envs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainBhyveCommandlineEnvs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Envs
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
