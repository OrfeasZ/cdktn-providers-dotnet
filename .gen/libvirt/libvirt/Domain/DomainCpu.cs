using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainCpu")]
    public class DomainCpu : libvirt.Domain.IDomainCpu
    {
        /// <summary>Configures CPU cache behavior for the guest, such as whether to copy or passthrough host cache information at a specific cache level.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#cache Domain#cache}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuCache\"}", isOptional: true)]
        public libvirt.Domain.IDomainCpuCache? Cache
        {
            get;
            set;
        }

        /// <summary>Controls how strictly the hypervisor verifies that the requested CPU model and features are supported on the host, with values like "none", "partial", or "full".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#check Domain#check}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "check", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Check
        {
            get;
            set;
        }

        /// <summary>Sets whether deprecated CPU features are allowed, typically using values such as "allow", "forbid", or "require" depending on host and hypervisor support.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#deprecated_features Domain#deprecated_features}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deprecatedFeatures", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeprecatedFeatures
        {
            get;
            set;
        }

        private object? _features;

        /// <summary>Lists additional per-feature overrides to enable, disable, or require specific CPU instruction set features for the guest.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#features Domain#features}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainCpuFeatures" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "features", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainCpuFeatures\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Features
        {
            get => _features;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainCpuFeatures[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainCpuFeatures).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _features = value;
            }
        }

        /// <summary>Selects how the requested CPU model is matched against the host, with valid values including "minimum", "exact", and "strict", affecting migration compatibility and feature guarantees.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#match Domain#match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Match
        {
            get;
            set;
        }

        /// <summary>Configures a limit on the physical address width visible to the guest, thereby constraining the maximum guest physical address range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#max_phys_addr Domain#max_phys_addr}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxPhysAddr", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuMaxPhysAddr\"}", isOptional: true)]
        public libvirt.Domain.IDomainCpuMaxPhysAddr? MaxPhysAddr
        {
            get;
            set;
        }

        private object? _migratable;

        /// <summary>Controls whether the configured CPU model is considered migratable between hosts, using "yes" or "no" string values.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#migratable Domain#migratable}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "migratable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Migratable
        {
            get => _migratable;
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
                _migratable = value;
            }
        }

        /// <summary>Selects the overall CPU model mode for the guest, such as "host-passthrough", "host-model", or "custom", determining how closely the guest CPU matches the host.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#mode Domain#mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Sets the CPU model name exposed to the guest when using a custom CPU mode, for example "Skylake-Server" or "EPYC".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model Domain#model}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Model
        {
            get;
            set;
        }

        /// <summary>Controls the fallback behavior for applying the requested CPU model (flattened from the cpu.model element), with valid values such as "allow", "forbid", or "legacy" depending on libvirt version.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model_fallback Domain#model_fallback}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modelFallback", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelFallback
        {
            get;
            set;
        }

        /// <summary>Sets a custom CPU vendor ID string for the exposed CPU model (flattened from the cpu.model element), allowing a user-provided vendor_id such as "AuthenticAMD" or "GenuineIntel".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#model_vendor_id Domain#model_vendor_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modelVendorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelVendorId
        {
            get;
            set;
        }

        /// <summary>Enables detailed NUMA topology specification for the guest CPU, acting as the container for one or more NUMA cells.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#numa Domain#numa}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numa", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuNuma\"}", isOptional: true)]
        public libvirt.Domain.IDomainCpuNuma? Numa
        {
            get;
            set;
        }

        /// <summary>Configures the virtual CPU topology presented to the guest, including the number of sockets, cores, threads, dies, and optional clusters;</summary>
        /// <remarks>
        /// if omitted, libvirt chooses a topology automatically.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#topology Domain#topology}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "topology", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTopology\"}", isOptional: true)]
        public libvirt.Domain.IDomainCpuTopology? Topology
        {
            get;
            set;
        }

        /// <summary>Specifies the CPU vendor string advertised to the guest (for example, "GenuineIntel" or "AuthenticAMD");</summary>
        /// <remarks>
        /// value is user-provided and must be supported by the underlying hypervisor.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#cpu-model-and-topology">https://libvirt.org/formatdomain.html#cpu-model-and-topology</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#vendor Domain#vendor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vendor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Vendor
        {
            get;
            set;
        }
    }
}
