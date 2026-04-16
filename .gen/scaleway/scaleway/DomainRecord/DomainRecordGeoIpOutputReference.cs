using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DomainRecord
{
    [JsiiClass(nativeType: typeof(scaleway.DomainRecord.DomainRecordGeoIpOutputReference), fullyQualifiedName: "scaleway.domainRecord.DomainRecordGeoIpOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DomainRecordGeoIpOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DomainRecordGeoIpOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainRecordGeoIpOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DomainRecordGeoIpOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMatches", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.domainRecord.DomainRecordGeoIpMatches\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMatches(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case scaleway.DomainRecord.IDomainRecordGeoIpMatches[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.DomainRecord.IDomainRecordGeoIpMatches).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.DomainRecord.IDomainRecordGeoIpMatches).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "matches", typeJson: "{\"fqn\":\"scaleway.domainRecord.DomainRecordGeoIpMatchesList\"}")]
        public virtual scaleway.DomainRecord.DomainRecordGeoIpMatchesList Matches
        {
            get => GetInstanceProperty<scaleway.DomainRecord.DomainRecordGeoIpMatchesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.domainRecord.DomainRecordGeoIpMatches\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MatchesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.domainRecord.DomainRecordGeoIp\"}", isOptional: true)]
        public virtual scaleway.DomainRecord.IDomainRecordGeoIp? InternalValue
        {
            get => GetInstanceProperty<scaleway.DomainRecord.IDomainRecordGeoIp?>();
            set => SetInstanceProperty(value);
        }
    }
}
