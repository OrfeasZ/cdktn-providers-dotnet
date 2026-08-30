using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesFilterRefParameters), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesFilterRefParameters")]
    public interface IDomainDevicesInterfacesFilterRefParameters
    {
        /// <summary>Sets the parameter name passed into the nwfilter definition;</summary>
        /// <remarks>
        /// value is user-provided and must match a parameter expected by the filter (for example, "IP", "MAC").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter">https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Sets the value for the named nwfilter parameter;</summary>
        /// <remarks>
        /// value is user-provided and typically encodes an address, port, or other match value (for example, "192.168.122.1").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter">https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesFilterRefParameters), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesFilterRefParameters")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesFilterRefParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the parameter name passed into the nwfilter definition;</summary>
            /// <remarks>
            /// value is user-provided and must match a parameter expected by the filter (for example, "IP", "MAC").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter">https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the value for the named nwfilter parameter;</summary>
            /// <remarks>
            /// value is user-provided and typically encodes an address, port, or other match value (for example, "192.168.122.1").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter">https://libvirt.org/formatdomain.html#traffic-filtering-with-nwfilter</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
