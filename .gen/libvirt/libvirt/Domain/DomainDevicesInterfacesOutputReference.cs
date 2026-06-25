using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiClass(nativeType: typeof(libvirt.Domain.DomainDevicesInterfacesOutputReference), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DomainDevicesInterfacesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DomainDevicesInterfacesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesInterfacesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainDevicesInterfacesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAcpi\"}}]")]
        public virtual void PutAcpi(libvirt.Domain.IDomainDevicesInterfacesAcpi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesAcpi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAddress\"}}]")]
        public virtual void PutAddress(libvirt.Domain.IDomainDevicesInterfacesAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAlias", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAlias\"}}]")]
        public virtual void PutAlias(libvirt.Domain.IDomainDevicesInterfacesAlias @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesAlias)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBackend", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBackend\"}}]")]
        public virtual void PutBackend(libvirt.Domain.IDomainDevicesInterfacesBackend @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesBackend)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBackendDomain", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBackendDomain\"}}]")]
        public virtual void PutBackendDomain(libvirt.Domain.IDomainDevicesInterfacesBackendDomain @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesBackendDomain)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBandwidth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBandwidth\"}}]")]
        public virtual void PutBandwidth(libvirt.Domain.IDomainDevicesInterfacesBandwidth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesBandwidth)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBoot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBoot\"}}]")]
        public virtual void PutBoot(libvirt.Domain.IDomainDevicesInterfacesBoot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesBoot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCoalesce", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesCoalesce\"}}]")]
        public virtual void PutCoalesce(libvirt.Domain.IDomainDevicesInterfacesCoalesce @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesCoalesce)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDownScript", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDownScript\"}}]")]
        public virtual void PutDownScript(libvirt.Domain.IDomainDevicesInterfacesDownScript @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesDownScript)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDriver", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDriver\"}}]")]
        public virtual void PutDriver(libvirt.Domain.IDomainDevicesInterfacesDriver @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesDriver)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFilterRef", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesFilterRef\"}}]")]
        public virtual void PutFilterRef(libvirt.Domain.IDomainDevicesInterfacesFilterRef @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesFilterRef)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGuest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesGuest\"}}]")]
        public virtual void PutGuest(libvirt.Domain.IDomainDevicesInterfacesGuest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesGuest)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesIp" />)[]</param>
        [JsiiMethod(name: "putIp", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesIp\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIp(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainDevicesInterfacesIp[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesIp).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesIp).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLink", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesLink\"}}]")]
        public virtual void PutLink(libvirt.Domain.IDomainDevicesInterfacesLink @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesLink)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMac", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesMac\"}}]")]
        public virtual void PutMac(libvirt.Domain.IDomainDevicesInterfacesMac @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesMac)}, new object[]{@value});
        }

        [JsiiMethod(name: "putModel", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesModel\"}}]")]
        public virtual void PutModel(libvirt.Domain.IDomainDevicesInterfacesModel @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesModel)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMtu", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesMtu\"}}]")]
        public virtual void PutMtu(libvirt.Domain.IDomainDevicesInterfacesMtu @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesMtu)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesPortForward" />)[]</param>
        [JsiiMethod(name: "putPortForward", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesPortForward\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPortForward(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainDevicesInterfacesPortForward[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesPortForward).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesPortForward).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPortOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesPortOptions\"}}]")]
        public virtual void PutPortOptions(libvirt.Domain.IDomainDevicesInterfacesPortOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesPortOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRom", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesRom\"}}]")]
        public virtual void PutRom(libvirt.Domain.IDomainDevicesInterfacesRom @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesRom)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesRoute" />)[]</param>
        [JsiiMethod(name: "putRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesRoute\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRoute(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case libvirt.Domain.IDomainDevicesInterfacesRoute[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesRoute).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfacesRoute).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScript", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesScript\"}}]")]
        public virtual void PutScript(libvirt.Domain.IDomainDevicesInterfacesScript @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesScript)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSource\"}}]")]
        public virtual void PutSource(libvirt.Domain.IDomainDevicesInterfacesSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTarget\"}}]")]
        public virtual void PutTarget(libvirt.Domain.IDomainDevicesInterfacesTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTeaming", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTeaming\"}}]")]
        public virtual void PutTeaming(libvirt.Domain.IDomainDevicesInterfacesTeaming @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesTeaming)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTune", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTune\"}}]")]
        public virtual void PutTune(libvirt.Domain.IDomainDevicesInterfacesTune @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesTune)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVirtualPort", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPort\"}}]")]
        public virtual void PutVirtualPort(libvirt.Domain.IDomainDevicesInterfacesVirtualPort @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesVirtualPort)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVlan", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVlan\"}}]")]
        public virtual void PutVlan(libvirt.Domain.IDomainDevicesInterfacesVlan @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesVlan)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWaitForIp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesWaitForIp\"}}]")]
        public virtual void PutWaitForIp(libvirt.Domain.IDomainDevicesInterfacesWaitForIp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(libvirt.Domain.IDomainDevicesInterfacesWaitForIp)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcpi")]
        public virtual void ResetAcpi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAddress")]
        public virtual void ResetAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAlias")]
        public virtual void ResetAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackend")]
        public virtual void ResetBackend()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackendDomain")]
        public virtual void ResetBackendDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBandwidth")]
        public virtual void ResetBandwidth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBoot")]
        public virtual void ResetBoot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCoalesce")]
        public virtual void ResetCoalesce()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDownScript")]
        public virtual void ResetDownScript()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDriver")]
        public virtual void ResetDriver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilterRef")]
        public virtual void ResetFilterRef()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGuest")]
        public virtual void ResetGuest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIp")]
        public virtual void ResetIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLink")]
        public virtual void ResetLink()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMac")]
        public virtual void ResetMac()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManaged")]
        public virtual void ResetManaged()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModel")]
        public virtual void ResetModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMtu")]
        public virtual void ResetMtu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPortForward")]
        public virtual void ResetPortForward()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPortOptions")]
        public virtual void ResetPortOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRom")]
        public virtual void ResetRom()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoute")]
        public virtual void ResetRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScript")]
        public virtual void ResetScript()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSource")]
        public virtual void ResetSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTarget")]
        public virtual void ResetTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTeaming")]
        public virtual void ResetTeaming()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrustGuestRxFilters")]
        public virtual void ResetTrustGuestRxFilters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTune")]
        public virtual void ResetTune()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualPort")]
        public virtual void ResetVirtualPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVlan")]
        public virtual void ResetVlan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitForIp")]
        public virtual void ResetWaitForIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "acpi", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAcpiOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesAcpiOutputReference Acpi
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesAcpiOutputReference>()!;
        }

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAddressOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesAddressOutputReference Address
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesAddressOutputReference>()!;
        }

        [JsiiProperty(name: "alias", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAliasOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesAliasOutputReference Alias
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesAliasOutputReference>()!;
        }

        [JsiiProperty(name: "backend", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBackendOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesBackendOutputReference Backend
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesBackendOutputReference>()!;
        }

        [JsiiProperty(name: "backendDomain", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBackendDomainOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesBackendDomainOutputReference BackendDomain
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesBackendDomainOutputReference>()!;
        }

        [JsiiProperty(name: "bandwidth", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBandwidthOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesBandwidthOutputReference Bandwidth
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesBandwidthOutputReference>()!;
        }

        [JsiiProperty(name: "boot", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBootOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesBootOutputReference Boot
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesBootOutputReference>()!;
        }

        [JsiiProperty(name: "coalesce", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesCoalesceOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesCoalesceOutputReference Coalesce
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesCoalesceOutputReference>()!;
        }

        [JsiiProperty(name: "downScript", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDownScriptOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesDownScriptOutputReference DownScript
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesDownScriptOutputReference>()!;
        }

        [JsiiProperty(name: "driver", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDriverOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesDriverOutputReference Driver
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesDriverOutputReference>()!;
        }

        [JsiiProperty(name: "filterRef", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesFilterRefOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesFilterRefOutputReference FilterRef
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesFilterRefOutputReference>()!;
        }

        [JsiiProperty(name: "guest", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesGuestOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesGuestOutputReference Guest
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesGuestOutputReference>()!;
        }

        [JsiiProperty(name: "ip", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesIpList\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesIpList Ip
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesIpList>()!;
        }

        [JsiiProperty(name: "link", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesLinkOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesLinkOutputReference Link
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesLinkOutputReference>()!;
        }

        [JsiiProperty(name: "mac", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesMacOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesMacOutputReference Mac
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesMacOutputReference>()!;
        }

        [JsiiProperty(name: "model", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesModelOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesModelOutputReference Model
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesModelOutputReference>()!;
        }

        [JsiiProperty(name: "mtu", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesMtuOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesMtuOutputReference Mtu
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesMtuOutputReference>()!;
        }

        [JsiiProperty(name: "portForward", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesPortForwardList\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesPortForwardList PortForward
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesPortForwardList>()!;
        }

        [JsiiProperty(name: "portOptions", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesPortOptionsOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesPortOptionsOutputReference PortOptions
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesPortOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "rom", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesRomOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesRomOutputReference Rom
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesRomOutputReference>()!;
        }

        [JsiiProperty(name: "route", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesRouteList\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesRouteList Route
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesRouteList>()!;
        }

        [JsiiProperty(name: "script", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesScriptOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesScriptOutputReference Script
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesScriptOutputReference>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSourceOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesSourceOutputReference Source
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesSourceOutputReference>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTargetOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesTargetOutputReference Target
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesTargetOutputReference>()!;
        }

        [JsiiProperty(name: "teaming", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTeamingOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesTeamingOutputReference Teaming
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesTeamingOutputReference>()!;
        }

        [JsiiProperty(name: "tune", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTuneOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesTuneOutputReference Tune
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesTuneOutputReference>()!;
        }

        [JsiiProperty(name: "virtualPort", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPortOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesVirtualPortOutputReference VirtualPort
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesVirtualPortOutputReference>()!;
        }

        [JsiiProperty(name: "vlan", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVlanOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesVlanOutputReference Vlan
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesVlanOutputReference>()!;
        }

        [JsiiProperty(name: "waitForIp", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesWaitForIpOutputReference\"}")]
        public virtual libvirt.Domain.DomainDevicesInterfacesWaitForIpOutputReference WaitForIp
        {
            get => GetInstanceProperty<libvirt.Domain.DomainDevicesInterfacesWaitForIpOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesAcpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acpiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAcpi\"}]}}", isOptional: true)]
        public virtual object? AcpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesAddress" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAddress\"}]}}", isOptional: true)]
        public virtual object? AddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesAlias" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesAlias\"}]}}", isOptional: true)]
        public virtual object? AliasInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesBackendDomain" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backendDomainInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBackendDomain\"}]}}", isOptional: true)]
        public virtual object? BackendDomainInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesBackend" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backendInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBackend\"}]}}", isOptional: true)]
        public virtual object? BackendInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesBandwidth" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bandwidthInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBandwidth\"}]}}", isOptional: true)]
        public virtual object? BandwidthInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesBoot" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bootInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesBoot\"}]}}", isOptional: true)]
        public virtual object? BootInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesCoalesce" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "coalesceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesCoalesce\"}]}}", isOptional: true)]
        public virtual object? CoalesceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesDownScript" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "downScriptInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDownScript\"}]}}", isOptional: true)]
        public virtual object? DownScriptInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesDriver" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesDriver\"}]}}", isOptional: true)]
        public virtual object? DriverInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesFilterRef" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterRefInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesFilterRef\"}]}}", isOptional: true)]
        public virtual object? FilterRefInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesGuest" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "guestInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesGuest\"}]}}", isOptional: true)]
        public virtual object? GuestInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesIp" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IpInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesLink" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "linkInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesLink\"}]}}", isOptional: true)]
        public virtual object? LinkInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesMac" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "macInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesMac\"}]}}", isOptional: true)]
        public virtual object? MacInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ManagedInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesModel" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modelInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesModel\"}]}}", isOptional: true)]
        public virtual object? ModelInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesMtu" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mtuInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesMtu\"}]}}", isOptional: true)]
        public virtual object? MtuInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesPortForward" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portForwardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesPortForward\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PortForwardInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesPortOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesPortOptions\"}]}}", isOptional: true)]
        public virtual object? PortOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesRom" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "romInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesRom\"}]}}", isOptional: true)]
        public virtual object? RomInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesRoute" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesRoute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RouteInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesScript" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scriptInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesScript\"}]}}", isOptional: true)]
        public virtual object? ScriptInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesSource" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesSource\"}]}}", isOptional: true)]
        public virtual object? SourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesTarget" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTarget\"}]}}", isOptional: true)]
        public virtual object? TargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesTeaming" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "teamingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTeaming\"}]}}", isOptional: true)]
        public virtual object? TeamingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustGuestRxFiltersInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrustGuestRxFiltersInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesTune" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tuneInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesTune\"}]}}", isOptional: true)]
        public virtual object? TuneInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesVirtualPort" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualPortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVirtualPort\"}]}}", isOptional: true)]
        public virtual object? VirtualPortInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesVlan" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vlanInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVlan\"}]}}", isOptional: true)]
        public virtual object? VlanInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfacesWaitForIp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "waitForIpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesWaitForIp\"}]}}", isOptional: true)]
        public virtual object? WaitForIpInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "managed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Managed
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

        [JsiiProperty(name: "trustGuestRxFilters", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrustGuestRxFilters
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="libvirt.Domain.IDomainDevicesInterfaces" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"libvirt.domain.DomainDevicesInterfaces\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Domain.IDomainDevicesInterfaces cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Domain.IDomainDevicesInterfaces).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
