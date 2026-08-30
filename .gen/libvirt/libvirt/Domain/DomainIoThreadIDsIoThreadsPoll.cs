using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainIoThreadIDsIoThreadsPoll")]
    public class DomainIoThreadIDsIoThreadsPoll : libvirt.Domain.IDomainIoThreadIDsIoThreadsPoll
    {
        /// <summary>Sets the per-IOThread poll configuration’s grow threshold, controlling how aggressively the IOThread poll mode ramps up;</summary>
        /// <remarks>
        /// the value is user-provided (typically a non‑negative integer).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#grow Domain#grow}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Grow
        {
            get;
            set;
        }

        /// <summary>Sets the maximum polling threshold for the IOThread, limiting how far the poll mode can scale;</summary>
        /// <remarks>
        /// the value is user-provided (typically a non‑negative integer).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max Domain#max}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Max
        {
            get;
            set;
        }

        /// <summary>Sets the per-IOThread poll configuration’s shrink threshold, controlling how quickly the IOThread backs off from poll mode;</summary>
        /// <remarks>
        /// the value is user-provided (typically a non‑negative integer).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#iothreads-allocation">https://libvirt.org/formatdomain.html#iothreads-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#shrink Domain#shrink}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shrink", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Shrink
        {
            get;
            set;
        }
    }
}
