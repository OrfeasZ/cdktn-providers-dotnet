using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiByValue(fqn: "libvirt.pool.PoolFsCommandline")]
    public class PoolFsCommandline : libvirt.Pool.IPoolFsCommandline
    {
        private object? _options;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#options Pool#options}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Pool.IPoolFsCommandlineOptions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "options", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.pool.PoolFsCommandlineOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Options
        {
            get => _options;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Pool.IPoolFsCommandlineOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Pool.IPoolFsCommandlineOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _options = value;
            }
        }
    }
}
