using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Pool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.pool.PoolSourceAuth")]
    public class PoolSourceAuth : libvirt.Pool.IPoolSourceAuth
    {
        /// <summary>Sets the authentication type used by the pool source, for example "ceph" for RBD pools or other backend-specific values;</summary>
        /// <remarks>
        /// the value is user-provided but must match what the storage backend expects.
        ///
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#type Pool#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Sets the username or client identifier used when authenticating to the storage backend (for example, a Ceph client name like "client.admin" or an iSCSI user).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatstorage.html#source-elements">https://libvirt.org/formatstorage.html#source-elements</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#username Pool#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }

        /// <summary>Configures the libvirt secret used for authenticating access to the storage pool source (for example, an RBD or iSCSI password);</summary>
        /// <remarks>
        /// either a secret UUID or a usage name must be provided via child attributes.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/pool#secret Pool#secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"libvirt.pool.PoolSourceAuthSecret\"}", isOptional: true)]
        public libvirt.Pool.IPoolSourceAuthSecret? Secret
        {
            get;
            set;
        }
    }
}
