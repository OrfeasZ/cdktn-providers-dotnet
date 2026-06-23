using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainVcpusVcpu), fullyQualifiedName: "libvirt.domain.DomainVcpusVcpu")]
    public interface IDomainVcpusVcpu
    {
        /// <summary>Controls whether this specific vCPU is online at startup, using a boolean‑like string value "yes" or "no" in the vcpu element’s enabled attribute.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#enabled Domain#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets whether this individual vCPU can be hotplugged on or off while the guest is running;</summary>
        /// <remarks>
        /// accepts the strings "yes" or "no".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hotpluggable Domain#hotpluggable}
        /// </remarks>
        [JsiiProperty(name: "hotpluggable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Hotpluggable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Reports the index of this vCPU within the guest (0-based, computed by libvirt and not configurable).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#id Domain#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the boot-time activation order for this vCPU relative to other vCPUs; the value is a user-provided non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#order Domain#order}
        /// </remarks>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Order
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainVcpusVcpu), fullyQualifiedName: "libvirt.domain.DomainVcpusVcpu")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainVcpusVcpu
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether this specific vCPU is online at startup, using a boolean‑like string value "yes" or "no" in the vcpu element’s enabled attribute.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#enabled Domain#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Enabled
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets whether this individual vCPU can be hotplugged on or off while the guest is running;</summary>
            /// <remarks>
            /// accepts the strings "yes" or "no".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#hotpluggable Domain#hotpluggable}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hotpluggable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Hotpluggable
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Reports the index of this vCPU within the guest (0-based, computed by libvirt and not configurable).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#id Domain#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Id
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the boot-time activation order for this vCPU relative to other vCPUs; the value is a user-provided non-negative integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#cpu-allocation">https://libvirt.org/formatdomain.html#cpu-allocation</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#order Domain#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Order
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
