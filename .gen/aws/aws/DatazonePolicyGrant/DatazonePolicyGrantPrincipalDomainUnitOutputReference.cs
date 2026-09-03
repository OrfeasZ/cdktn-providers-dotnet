using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    [JsiiClass(nativeType: typeof(aws.DatazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnitOutputReference), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnitOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DatazonePolicyGrantPrincipalDomainUnitOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DatazonePolicyGrantPrincipalDomainUnitOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DatazonePolicyGrantPrincipalDomainUnitOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatazonePolicyGrantPrincipalDomainUnitOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilter" />)[]</param>
        [JsiiMethod(name: "putAllDomainUnitsGrantFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAllDomainUnitsGrantFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllDomainUnitsGrantFilter")]
        public virtual void ResetAllDomainUnitsGrantFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomainUnitIdentifier")]
        public virtual void ResetDomainUnitIdentifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "allDomainUnitsGrantFilter", typeJson: "{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilterList\"}")]
        public virtual aws.DatazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilterList AllDomainUnitsGrantFilter
        {
            get => GetInstanceProperty<aws.DatazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilterList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allDomainUnitsGrantFilterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnitAllDomainUnitsGrantFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AllDomainUnitsGrantFilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainUnitDesignationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainUnitDesignationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainUnitIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainUnitIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "domainUnitDesignation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainUnitDesignation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainUnitIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainUnitIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnit\"}]}}", isOptional: true)]
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
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnit cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnit).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
