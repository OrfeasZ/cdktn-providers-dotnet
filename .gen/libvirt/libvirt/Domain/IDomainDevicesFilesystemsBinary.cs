using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesFilesystemsBinary), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsBinary")]
    public interface IDomainDevicesFilesystemsBinary
    {
        /// <summary>Configures caching behavior for the filesystem helper binary, such as how it caches file metadata or data.</summary>
        /// <remarks>
        /// The effective policy is controlled by the required mode attribute.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cache Domain#cache}
        /// </remarks>
        [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryCache\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesFilesystemsBinaryCache? Cache
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures file locking behavior used by the filesystem helper binary when accessing shared host files.</summary>
        /// <remarks>
        /// Its flock and posix attributes enable or disable the respective locking mechanisms.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#lock Domain#lock}
        /// </remarks>
        [JsiiProperty(name: "lock", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryLock\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesFilesystemsBinaryLock? Lock
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures limits related to the number of open files the filesystem helper binary may keep, helping constrain resource usage.</summary>
        /// <remarks>
        /// The max attribute defines the actual numeric limit.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#open_files Domain#open_files}
        /// </remarks>
        [JsiiProperty(name: "openFiles", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryOpenFiles\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesFilesystemsBinaryOpenFiles? OpenFiles
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the absolute path to the filesystem helper binary (such as a virtiofsd-style daemon) that will be executed to serve this filesystem.</summary>
        /// <remarks>
        /// Value is user-provided and must point to an executable on the host (for example, "/usr/libexec/virtiofsd").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures sandboxing behavior for the filesystem helper binary, such as whether it runs in a restricted environment.</summary>
        /// <remarks>
        /// The mode attribute selects the sandboxing policy.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sandbox Domain#sandbox}
        /// </remarks>
        [JsiiProperty(name: "sandbox", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinarySandbox\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesFilesystemsBinarySandbox? Sandbox
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures the thread pool used by the filesystem helper binary to handle I/O requests.</summary>
        /// <remarks>
        /// The size attribute controls the number of worker threads.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#thread_pool Domain#thread_pool}
        /// </remarks>
        [JsiiProperty(name: "threadPool", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryThreadPool\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesFilesystemsBinaryThreadPool? ThreadPool
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables or disables extended attribute (xattr) support for the filesystem helper binary when exporting the filesystem;</summary>
        /// <remarks>
        /// value is typically "on"/"off" or "yes"/"no". When omitted, the backend default is used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#xattr Domain#xattr}
        /// </remarks>
        [JsiiProperty(name: "xattr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Xattr
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesFilesystemsBinary), fullyQualifiedName: "libvirt.domain.DomainDevicesFilesystemsBinary")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesFilesystemsBinary
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures caching behavior for the filesystem helper binary, such as how it caches file metadata or data.</summary>
            /// <remarks>
            /// The effective policy is controlled by the required mode attribute.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#cache Domain#cache}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryCache\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesFilesystemsBinaryCache? Cache
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesFilesystemsBinaryCache?>();
            }

            /// <summary>Configures file locking behavior used by the filesystem helper binary when accessing shared host files.</summary>
            /// <remarks>
            /// Its flock and posix attributes enable or disable the respective locking mechanisms.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#lock Domain#lock}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lock", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryLock\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesFilesystemsBinaryLock? Lock
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesFilesystemsBinaryLock?>();
            }

            /// <summary>Configures limits related to the number of open files the filesystem helper binary may keep, helping constrain resource usage.</summary>
            /// <remarks>
            /// The max attribute defines the actual numeric limit.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#open_files Domain#open_files}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "openFiles", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryOpenFiles\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesFilesystemsBinaryOpenFiles? OpenFiles
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesFilesystemsBinaryOpenFiles?>();
            }

            /// <summary>Sets the absolute path to the filesystem helper binary (such as a virtiofsd-style daemon) that will be executed to serve this filesystem.</summary>
            /// <remarks>
            /// Value is user-provided and must point to an executable on the host (for example, "/usr/libexec/virtiofsd").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#filesystems">https://libvirt.org/formatdomain.html#filesystems</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#path Domain#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configures sandboxing behavior for the filesystem helper binary, such as whether it runs in a restricted environment.</summary>
            /// <remarks>
            /// The mode attribute selects the sandboxing policy.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#sandbox Domain#sandbox}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sandbox", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinarySandbox\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesFilesystemsBinarySandbox? Sandbox
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesFilesystemsBinarySandbox?>();
            }

            /// <summary>Configures the thread pool used by the filesystem helper binary to handle I/O requests.</summary>
            /// <remarks>
            /// The size attribute controls the number of worker threads.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#thread_pool Domain#thread_pool}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threadPool", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesFilesystemsBinaryThreadPool\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesFilesystemsBinaryThreadPool? ThreadPool
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesFilesystemsBinaryThreadPool?>();
            }

            /// <summary>Enables or disables extended attribute (xattr) support for the filesystem helper binary when exporting the filesystem;</summary>
            /// <remarks>
            /// value is typically "on"/"off" or "yes"/"no". When omitted, the backend default is used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#xattr Domain#xattr}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xattr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Xattr
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
