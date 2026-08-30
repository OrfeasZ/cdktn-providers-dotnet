using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain libvirt_domain}.</summary>
    [JsiiClass(nativeType: typeof(libvirt.Domain.Domain), fullyQualifiedName: "libvirt.domain.Domain", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"libvirt.domain.DomainConfig\"}}]")]
    public class Domain : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain libvirt_domain} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Domain(Constructs.Construct scope, string id, libvirt.Domain.IDomainConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, libvirt.Domain.IDomainConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Domain(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Domain(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Domain resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Domain to import.</param>
        /// <param name="importFromId">The id of the existing Domain that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Domain to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Domain to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Domain that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Domain to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(libvirt.Domain.Domain), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBhyveCommandline", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainBhyveCommandline\"}}]")]
        public virtual void PutBhyveCommandline(libvirt.Domain.IDomainBhyveCommandline @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainBhyveCommandline)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlockIoTune", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainBlockIoTune\"}}]")]
        public virtual void PutBlockIoTune(libvirt.Domain.IDomainBlockIoTune @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainBlockIoTune)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClock", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainClock\"}}]")]
        public virtual void PutClock(libvirt.Domain.IDomainClock @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainClock)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCpu", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainCpu\"}}]")]
        public virtual void PutCpu(libvirt.Domain.IDomainCpu @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainCpu)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCpuTune", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainCpuTune\"}}]")]
        public virtual void PutCpuTune(libvirt.Domain.IDomainCpuTune @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainCpuTune)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCreate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainCreate\"}}]")]
        public virtual void PutCreate(libvirt.Domain.IDomainCreate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainCreate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDefaultIoThread", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDefaultIoThread\"}}]")]
        public virtual void PutDefaultIoThread(libvirt.Domain.IDomainDefaultIoThread @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDefaultIoThread)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDestroy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDestroy\"}}]")]
        public virtual void PutDestroy(libvirt.Domain.IDomainDestroy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDestroy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDevices", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevices\"}}]")]
        public virtual void PutDevices(libvirt.Domain.IDomainDevices @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevices)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFeatures", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainFeatures\"}}]")]
        public virtual void PutFeatures(libvirt.Domain.IDomainFeatures @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainFeatures)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdMap", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainIdMap\"}}]")]
        public virtual void PutIdMap(libvirt.Domain.IDomainIdMap @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainIdMap)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIommufd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainIommufd\"}}]")]
        public virtual void PutIommufd(libvirt.Domain.IDomainIommufd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainIommufd)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIoThreadIDs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainIoThreadIDs\"}}]")]
        public virtual void PutIoThreadIDs(libvirt.Domain.IDomainIoThreadIDs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainIoThreadIDs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKeyWrap", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainKeyWrap\"}}]")]
        public virtual void PutKeyWrap(libvirt.Domain.IDomainKeyWrap @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainKeyWrap)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLaunchSecurity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainLaunchSecurity\"}}]")]
        public virtual void PutLaunchSecurity(libvirt.Domain.IDomainLaunchSecurity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainLaunchSecurity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLxcNamespace", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainLxcNamespace\"}}]")]
        public virtual void PutLxcNamespace(libvirt.Domain.IDomainLxcNamespace @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainLxcNamespace)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMemoryBacking", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainMemoryBacking\"}}]")]
        public virtual void PutMemoryBacking(libvirt.Domain.IDomainMemoryBacking @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainMemoryBacking)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMemoryTune", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainMemoryTune\"}}]")]
        public virtual void PutMemoryTune(libvirt.Domain.IDomainMemoryTune @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainMemoryTune)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetadata", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainMetadata\"}}]")]
        public virtual void PutMetadata(libvirt.Domain.IDomainMetadata @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainMetadata)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNumaTune", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainNumaTune\"}}]")]
        public virtual void PutNumaTune(libvirt.Domain.IDomainNumaTune @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainNumaTune)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainOs\"}}]")]
        public virtual void PutOs(libvirt.Domain.IDomainOs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainOs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPerf", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainPerf\"}}]")]
        public virtual void PutPerf(libvirt.Domain.IDomainPerf @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainPerf)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainPm\"}}]")]
        public virtual void PutPm(libvirt.Domain.IDomainPm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainPm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQemuCapabilities", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainQemuCapabilities\"}}]")]
        public virtual void PutQemuCapabilities(libvirt.Domain.IDomainQemuCapabilities @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainQemuCapabilities)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQemuCommandline", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainQemuCommandline\"}}]")]
        public virtual void PutQemuCommandline(libvirt.Domain.IDomainQemuCommandline @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainQemuCommandline)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQemuDeprecation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainQemuDeprecation\"}}]")]
        public virtual void PutQemuDeprecation(libvirt.Domain.IDomainQemuDeprecation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainQemuDeprecation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQemuOverride", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainQemuOverride\"}}]")]
        public virtual void PutQemuOverride(libvirt.Domain.IDomainQemuOverride @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainQemuOverride)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainResource\"}}]")]
        public virtual void PutResource(libvirt.Domain.IDomainResource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainResource)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSecLabel" />)[]</param>
        [JsiiMethod(name: "putSecLabel", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSecLabel\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecLabel(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainSecLabel[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSecLabel).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSecLabel).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfo" />)[]</param>
        [JsiiMethod(name: "putSysInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfo\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSysInfo(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainSysInfo[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSysInfo).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainSysInfo).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThrottleGroups", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainThrottleGroups\"}}]")]
        public virtual void PutThrottleGroups(libvirt.Domain.IDomainThrottleGroups @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainThrottleGroups)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpdate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainUpdate\"}}]")]
        public virtual void PutUpdate(libvirt.Domain.IDomainUpdate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainUpdate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVcpus", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainVcpus\"}}]")]
        public virtual void PutVcpus(libvirt.Domain.IDomainVcpus @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainVcpus)}, new object[]{@value});
        }

        [JsiiMethod(name: "putXenCommandline", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainXenCommandline\"}}]")]
        public virtual void PutXenCommandline(libvirt.Domain.IDomainXenCommandline @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainXenCommandline)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutostart")]
        public virtual void ResetAutostart()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBhyveCommandline")]
        public virtual void ResetBhyveCommandline()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockIoTune")]
        public virtual void ResetBlockIoTune()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBootloader")]
        public virtual void ResetBootloader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBootloaderArgs")]
        public virtual void ResetBootloaderArgs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClock")]
        public virtual void ResetClock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpu")]
        public virtual void ResetCpu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuTune")]
        public virtual void ResetCpuTune()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreate")]
        public virtual void ResetCreate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCurrentMemory")]
        public virtual void ResetCurrentMemory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCurrentMemoryUnit")]
        public virtual void ResetCurrentMemoryUnit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultIoThread")]
        public virtual void ResetDefaultIoThread()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestroy")]
        public virtual void ResetDestroy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDevices")]
        public virtual void ResetDevices()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeatures")]
        public virtual void ResetFeatures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGenId")]
        public virtual void ResetGenId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHwuuid")]
        public virtual void ResetHwuuid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdMap")]
        public virtual void ResetIdMap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIommufd")]
        public virtual void ResetIommufd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIoThreadIDs")]
        public virtual void ResetIoThreadIDs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIoThreads")]
        public virtual void ResetIoThreads()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyWrap")]
        public virtual void ResetKeyWrap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchSecurity")]
        public virtual void ResetLaunchSecurity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLxcNamespace")]
        public virtual void ResetLxcNamespace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumMemory")]
        public virtual void ResetMaximumMemory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumMemorySlots")]
        public virtual void ResetMaximumMemorySlots()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumMemoryUnit")]
        public virtual void ResetMaximumMemoryUnit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemory")]
        public virtual void ResetMemory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryBacking")]
        public virtual void ResetMemoryBacking()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryDumpCore")]
        public virtual void ResetMemoryDumpCore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryTune")]
        public virtual void ResetMemoryTune()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryUnit")]
        public virtual void ResetMemoryUnit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumaTune")]
        public virtual void ResetNumaTune()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnCrash")]
        public virtual void ResetOnCrash()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnPoweroff")]
        public virtual void ResetOnPoweroff()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnReboot")]
        public virtual void ResetOnReboot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOs")]
        public virtual void ResetOs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPerf")]
        public virtual void ResetPerf()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPm")]
        public virtual void ResetPm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQemuCapabilities")]
        public virtual void ResetQemuCapabilities()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQemuCommandline")]
        public virtual void ResetQemuCommandline()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQemuDeprecation")]
        public virtual void ResetQemuDeprecation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQemuOverride")]
        public virtual void ResetQemuOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResource")]
        public virtual void ResetResource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunning")]
        public virtual void ResetRunning()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecLabel")]
        public virtual void ResetSecLabel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSysInfo")]
        public virtual void ResetSysInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThrottleGroups")]
        public virtual void ResetThrottleGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTitle")]
        public virtual void ResetTitle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdate")]
        public virtual void ResetUpdate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVcpu")]
        public virtual void ResetVcpu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVcpuCpuset")]
        public virtual void ResetVcpuCpuset()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVcpuCurrent")]
        public virtual void ResetVcpuCurrent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVcpuPlacement")]
        public virtual void ResetVcpuPlacement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVcpus")]
        public virtual void ResetVcpus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVmwareDataCenterPath")]
        public virtual void ResetVmwareDataCenterPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXenCommandline")]
        public virtual void ResetXenCommandline()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(libvirt.Domain.Domain))!;

        [JsiiProperty(name: "bhyveCommandline", typeJson: "{\"fqn\":\"libvirt.domain.DomainBhyveCommandlineOutputReference\"}")]
        public virtual libvirt.Domain.DomainBhyveCommandlineOutputReference BhyveCommandline
        {
            get => GetInstanceProperty<libvirt.Domain.DomainBhyveCommandlineOutputReference>()!;
        }

        [JsiiProperty(name: "blockIoTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainBlockIoTuneOutputReference\"}")]
        public virtual libvirt.Domain.DomainBlockIoTuneOutputReference BlockIoTune
        {
            get => GetInstanceProperty<libvirt.Domain.DomainBlockIoTuneOutputReference>()!;
        }

        [JsiiProperty(name: "clock", typeJson: "{\"fqn\":\"libvirt.domain.DomainClockOutputReference\"}")]
        public virtual libvirt.Domain.DomainClockOutputReference Clock
        {
            get => GetInstanceProperty<libvirt.Domain.DomainClockOutputReference>()!;
        }

        [JsiiProperty(name: "cpu", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuOutputReference\"}")]
        public virtual libvirt.Domain.DomainCpuOutputReference Cpu
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuOutputReference>()!;
        }

        [JsiiProperty(name: "cpuTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainCpuTuneOutputReference\"}")]
        public virtual libvirt.Domain.DomainCpuTuneOutputReference CpuTune
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCpuTuneOutputReference>()!;
        }

        [JsiiProperty(name: "create", typeJson: "{\"fqn\":\"libvirt.domain.DomainCreateOutputReference\"}")]
        public virtual libvirt.Domain.DomainCreateOutputReference Create
        {
            get => GetInstanceProperty<libvirt.Domain.DomainCreateOutputReference>()!;
        }

        [JsiiProperty(name: "defaultIoThread", typeJson: "{\"fqn\":\"libvirt.domain.DomainDefaultIoThreadOutputReference\"}")]
        public virtual libvirt.Domain.DomainDefaultIoThreadOutputReference DefaultIoThread
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDefaultIoThreadOutputReference>()!;
        }

        [JsiiProperty(name: "destroy", typeJson: "{\"fqn\":\"libvirt.domain.DomainDestroyOutputReference\"}")]
        public virtual libvirt.Domain.DomainDestroyOutputReference Destroy
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDestroyOutputReference>()!;
        }

        [JsiiProperty(name: "devices", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesOutputReference Devices
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesOutputReference>()!;
        }

        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"libvirt.domain.DomainFeaturesOutputReference\"}")]
        public virtual libvirt.Domain.DomainFeaturesOutputReference Features
        {
            get => GetInstanceProperty<libvirt.Domain.DomainFeaturesOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Id
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "idMap", typeJson: "{\"fqn\":\"libvirt.domain.DomainIdMapOutputReference\"}")]
        public virtual libvirt.Domain.DomainIdMapOutputReference IdMap
        {
            get => GetInstanceProperty<libvirt.Domain.DomainIdMapOutputReference>()!;
        }

        [JsiiProperty(name: "iommufd", typeJson: "{\"fqn\":\"libvirt.domain.DomainIommufdOutputReference\"}")]
        public virtual libvirt.Domain.DomainIommufdOutputReference Iommufd
        {
            get => GetInstanceProperty<libvirt.Domain.DomainIommufdOutputReference>()!;
        }

        [JsiiProperty(name: "ioThreadIDs", typeJson: "{\"fqn\":\"libvirt.domain.DomainIoThreadIDsOutputReference\"}")]
        public virtual libvirt.Domain.DomainIoThreadIDsOutputReference IoThreadIDs
        {
            get => GetInstanceProperty<libvirt.Domain.DomainIoThreadIDsOutputReference>()!;
        }

        [JsiiProperty(name: "keyWrap", typeJson: "{\"fqn\":\"libvirt.domain.DomainKeyWrapOutputReference\"}")]
        public virtual libvirt.Domain.DomainKeyWrapOutputReference KeyWrap
        {
            get => GetInstanceProperty<libvirt.Domain.DomainKeyWrapOutputReference>()!;
        }

        [JsiiProperty(name: "launchSecurity", typeJson: "{\"fqn\":\"libvirt.domain.DomainLaunchSecurityOutputReference\"}")]
        public virtual libvirt.Domain.DomainLaunchSecurityOutputReference LaunchSecurity
        {
            get => GetInstanceProperty<libvirt.Domain.DomainLaunchSecurityOutputReference>()!;
        }

        [JsiiProperty(name: "lxcNamespace", typeJson: "{\"fqn\":\"libvirt.domain.DomainLxcNamespaceOutputReference\"}")]
        public virtual libvirt.Domain.DomainLxcNamespaceOutputReference LxcNamespace
        {
            get => GetInstanceProperty<libvirt.Domain.DomainLxcNamespaceOutputReference>()!;
        }

        [JsiiProperty(name: "memoryBacking", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryBackingOutputReference\"}")]
        public virtual libvirt.Domain.DomainMemoryBackingOutputReference MemoryBacking
        {
            get => GetInstanceProperty<libvirt.Domain.DomainMemoryBackingOutputReference>()!;
        }

        [JsiiProperty(name: "memoryTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainMemoryTuneOutputReference\"}")]
        public virtual libvirt.Domain.DomainMemoryTuneOutputReference MemoryTune
        {
            get => GetInstanceProperty<libvirt.Domain.DomainMemoryTuneOutputReference>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"libvirt.domain.DomainMetadataOutputReference\"}")]
        public virtual libvirt.Domain.DomainMetadataOutputReference Metadata
        {
            get => GetInstanceProperty<libvirt.Domain.DomainMetadataOutputReference>()!;
        }

        [JsiiProperty(name: "numaTune", typeJson: "{\"fqn\":\"libvirt.domain.DomainNumaTuneOutputReference\"}")]
        public virtual libvirt.Domain.DomainNumaTuneOutputReference NumaTune
        {
            get => GetInstanceProperty<libvirt.Domain.DomainNumaTuneOutputReference>()!;
        }

        [JsiiProperty(name: "os", typeJson: "{\"fqn\":\"libvirt.domain.DomainOsOutputReference\"}")]
        public virtual libvirt.Domain.DomainOsOutputReference Os
        {
            get => GetInstanceProperty<libvirt.Domain.DomainOsOutputReference>()!;
        }

        [JsiiProperty(name: "perf", typeJson: "{\"fqn\":\"libvirt.domain.DomainPerfOutputReference\"}")]
        public virtual libvirt.Domain.DomainPerfOutputReference Perf
        {
            get => GetInstanceProperty<libvirt.Domain.DomainPerfOutputReference>()!;
        }

        [JsiiProperty(name: "pm", typeJson: "{\"fqn\":\"libvirt.domain.DomainPmOutputReference\"}")]
        public virtual libvirt.Domain.DomainPmOutputReference Pm
        {
            get => GetInstanceProperty<libvirt.Domain.DomainPmOutputReference>()!;
        }

        [JsiiProperty(name: "qemuCapabilities", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuCapabilitiesOutputReference\"}")]
        public virtual libvirt.Domain.DomainQemuCapabilitiesOutputReference QemuCapabilities
        {
            get => GetInstanceProperty<libvirt.Domain.DomainQemuCapabilitiesOutputReference>()!;
        }

        [JsiiProperty(name: "qemuCommandline", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuCommandlineOutputReference\"}")]
        public virtual libvirt.Domain.DomainQemuCommandlineOutputReference QemuCommandline
        {
            get => GetInstanceProperty<libvirt.Domain.DomainQemuCommandlineOutputReference>()!;
        }

        [JsiiProperty(name: "qemuDeprecation", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuDeprecationOutputReference\"}")]
        public virtual libvirt.Domain.DomainQemuDeprecationOutputReference QemuDeprecation
        {
            get => GetInstanceProperty<libvirt.Domain.DomainQemuDeprecationOutputReference>()!;
        }

        [JsiiProperty(name: "qemuOverride", typeJson: "{\"fqn\":\"libvirt.domain.DomainQemuOverrideOutputReference\"}")]
        public virtual libvirt.Domain.DomainQemuOverrideOutputReference QemuOverride
        {
            get => GetInstanceProperty<libvirt.Domain.DomainQemuOverrideOutputReference>()!;
        }

        [JsiiProperty(name: "resource", typeJson: "{\"fqn\":\"libvirt.domain.DomainResourceOutputReference\"}")]
        public virtual libvirt.Domain.DomainResourceOutputReference Resource
        {
            get => GetInstanceProperty<libvirt.Domain.DomainResourceOutputReference>()!;
        }

        [JsiiProperty(name: "secLabel", typeJson: "{\"fqn\":\"libvirt.domain.DomainSecLabelList\"}")]
        public virtual libvirt.Domain.DomainSecLabelList SecLabel
        {
            get => GetInstanceProperty<libvirt.Domain.DomainSecLabelList>()!;
        }

        [JsiiProperty(name: "sysInfo", typeJson: "{\"fqn\":\"libvirt.domain.DomainSysInfoList\"}")]
        public virtual libvirt.Domain.DomainSysInfoList SysInfo
        {
            get => GetInstanceProperty<libvirt.Domain.DomainSysInfoList>()!;
        }

        [JsiiProperty(name: "throttleGroups", typeJson: "{\"fqn\":\"libvirt.domain.DomainThrottleGroupsOutputReference\"}")]
        public virtual libvirt.Domain.DomainThrottleGroupsOutputReference ThrottleGroups
        {
            get => GetInstanceProperty<libvirt.Domain.DomainThrottleGroupsOutputReference>()!;
        }

        [JsiiProperty(name: "update", typeJson: "{\"fqn\":\"libvirt.domain.DomainUpdateOutputReference\"}")]
        public virtual libvirt.Domain.DomainUpdateOutputReference Update
        {
            get => GetInstanceProperty<libvirt.Domain.DomainUpdateOutputReference>()!;
        }

        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vcpus", typeJson: "{\"fqn\":\"libvirt.domain.DomainVcpusOutputReference\"}")]
        public virtual libvirt.Domain.DomainVcpusOutputReference Vcpus
        {
            get => GetInstanceProperty<libvirt.Domain.DomainVcpusOutputReference>()!;
        }

        [JsiiProperty(name: "xenCommandline", typeJson: "{\"fqn\":\"libvirt.domain.DomainXenCommandlineOutputReference\"}")]
        public virtual libvirt.Domain.DomainXenCommandlineOutputReference XenCommandline
        {
            get => GetInstanceProperty<libvirt.Domain.DomainXenCommandlineOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autostartInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutostartInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainBhyveCommandline" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bhyveCommandlineInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainBhyveCommandline\"}]}}", isOptional: true)]
        public virtual object? BhyveCommandlineInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainBlockIoTune" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockIoTuneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainBlockIoTune\"}]}}", isOptional: true)]
        public virtual object? BlockIoTuneInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootloaderArgsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BootloaderArgsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootloaderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BootloaderInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainClock" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clockInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainClock\"}]}}", isOptional: true)]
        public virtual object? ClockInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainCpu" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cpuInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainCpu\"}]}}", isOptional: true)]
        public virtual object? CpuInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainCpuTune" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cpuTuneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainCpuTune\"}]}}", isOptional: true)]
        public virtual object? CpuTuneInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainCreate" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainCreate\"}]}}", isOptional: true)]
        public virtual object? CreateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currentMemoryInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CurrentMemoryInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currentMemoryUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurrentMemoryUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDefaultIoThread" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultIoThreadInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDefaultIoThread\"}]}}", isOptional: true)]
        public virtual object? DefaultIoThreadInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDestroy" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destroyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDestroy\"}]}}", isOptional: true)]
        public virtual object? DestroyInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevices" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "devicesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevices\"}]}}", isOptional: true)]
        public virtual object? DevicesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainFeatures" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "featuresInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainFeatures\"}]}}", isOptional: true)]
        public virtual object? FeaturesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "genIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GenIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hwuuidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HwuuidInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainIdMap" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idMapInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainIdMap\"}]}}", isOptional: true)]
        public virtual object? IdMapInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainIommufd" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iommufdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainIommufd\"}]}}", isOptional: true)]
        public virtual object? IommufdInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainIoThreadIDs" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ioThreadIDsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainIoThreadIDs\"}]}}", isOptional: true)]
        public virtual object? IoThreadIDsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ioThreadsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IoThreadsInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainKeyWrap" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyWrapInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainKeyWrap\"}]}}", isOptional: true)]
        public virtual object? KeyWrapInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainLaunchSecurity" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "launchSecurityInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainLaunchSecurity\"}]}}", isOptional: true)]
        public virtual object? LaunchSecurityInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainLxcNamespace" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lxcNamespaceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainLxcNamespace\"}]}}", isOptional: true)]
        public virtual object? LxcNamespaceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumMemoryInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumMemoryInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumMemorySlotsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumMemorySlotsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumMemoryUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaximumMemoryUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainMemoryBacking" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryBackingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainMemoryBacking\"}]}}", isOptional: true)]
        public virtual object? MemoryBackingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryDumpCoreInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MemoryDumpCoreInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemoryInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainMemoryTune" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "memoryTuneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainMemoryTune\"}]}}", isOptional: true)]
        public virtual object? MemoryTuneInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MemoryUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainMetadata" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainMetadata\"}]}}", isOptional: true)]
        public virtual object? MetadataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainNumaTune" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numaTuneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainNumaTune\"}]}}", isOptional: true)]
        public virtual object? NumaTuneInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onCrashInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OnCrashInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onPoweroffInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OnPoweroffInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onRebootInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OnRebootInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainOs" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "osInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainOs\"}]}}", isOptional: true)]
        public virtual object? OsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainPerf" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "perfInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainPerf\"}]}}", isOptional: true)]
        public virtual object? PerfInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainPm" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pmInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainPm\"}]}}", isOptional: true)]
        public virtual object? PmInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainQemuCapabilities" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "qemuCapabilitiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainQemuCapabilities\"}]}}", isOptional: true)]
        public virtual object? QemuCapabilitiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainQemuCommandline" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "qemuCommandlineInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainQemuCommandline\"}]}}", isOptional: true)]
        public virtual object? QemuCommandlineInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainQemuDeprecation" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "qemuDeprecationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainQemuDeprecation\"}]}}", isOptional: true)]
        public virtual object? QemuDeprecationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainQemuOverride" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "qemuOverrideInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainQemuOverride\"}]}}", isOptional: true)]
        public virtual object? QemuOverrideInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainResource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainResource\"}]}}", isOptional: true)]
        public virtual object? ResourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runningInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RunningInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSecLabel" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secLabelInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSecLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecLabelInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfo" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sysInfoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SysInfoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainThrottleGroups" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "throttleGroupsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainThrottleGroups\"}]}}", isOptional: true)]
        public virtual object? ThrottleGroupsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "titleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TitleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainUpdate" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "updateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainUpdate\"}]}}", isOptional: true)]
        public virtual object? UpdateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcpuCpusetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VcpuCpusetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcpuCurrentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VcpuCurrentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcpuInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VcpuInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcpuPlacementInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VcpuPlacementInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainVcpus" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vcpusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainVcpus\"}]}}", isOptional: true)]
        public virtual object? VcpusInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmwareDataCenterPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VmwareDataCenterPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainXenCommandline" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xenCommandlineInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainXenCommandline\"}]}}", isOptional: true)]
        public virtual object? XenCommandlineInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "autostart", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Autostart
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "bootloader", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bootloader
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bootloaderArgs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootloaderArgs
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "currentMemory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CurrentMemory
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "currentMemoryUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentMemoryUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "genId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GenId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hwuuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hwuuid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ioThreads", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IoThreads
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumMemory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumMemory
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumMemorySlots", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumMemorySlots
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumMemoryUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaximumMemoryUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Memory
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memoryDumpCore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemoryDumpCore
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memoryUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemoryUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onCrash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnCrash
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onPoweroff", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnPoweroff
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onReboot", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnReboot
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "running", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Running
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vcpu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Vcpu
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vcpuCpuset", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcpuCpuset
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vcpuCurrent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VcpuCurrent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vcpuPlacement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcpuPlacement
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vmwareDataCenterPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmwareDataCenterPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
