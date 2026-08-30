using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDefaultIoThread")]
    public class DomainDefaultIoThread : libvirt.Domain.IDomainDefaultIoThread
    {
        /// <summary>Sets the maximum number of threads in the default IOThread pool;</summary>
        /// <remarks>
        /// value is user-provided and must be a non‑negative integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pool_max Domain#pool_max}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "poolMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PoolMax
        {
            get;
            set;
        }

        /// <summary>Sets the minimum number of threads in the default IOThread pool;</summary>
        /// <remarks>
        /// value is user-provided and must be a non‑negative integer not greater than pool_max.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#pool_min Domain#pool_min}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "poolMin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PoolMin
        {
            get;
            set;
        }
    }
}
