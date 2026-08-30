using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    [JsiiByValue(fqn: "libvirt.pool.PoolSourceAuthSecret")]
    public class PoolSourceAuthSecret : libvirt.Pool.IPoolSourceAuthSecret
    {
        /// <summary>Sets the application-specific usage name of the secret to use for pool authentication, as defined in the corresponding libvirt secret object (user-provided string such as "ceph-secret").</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#usage Pool#usage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Usage
        {
            get;
            set;
        }

        /// <summary>Exposes the UUID of the libvirt secret used for pool authentication;</summary>
        /// <remarks>
        /// this is computed from the referenced secret and must be a valid libvirt UUID string when set.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/pool#uuid Pool#uuid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uuid
        {
            get;
            set;
        }
    }
}
