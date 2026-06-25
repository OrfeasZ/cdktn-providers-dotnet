using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiClass(nativeType: typeof(oci.PsqlDbSystem.PsqlDbSystemOdspInsightDetailsOutputReference), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemOdspInsightDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PsqlDbSystemOdspInsightDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PsqlDbSystemOdspInsightDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PsqlDbSystemOdspInsightDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PsqlDbSystemOdspInsightDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetailsOdspInsightListStruct" />)[]</param>
        [JsiiMethod(name: "putOdspInsightList", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemOdspInsightDetailsOdspInsightListStruct\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOdspInsightList(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetailsOdspInsightListStruct[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetailsOdspInsightListStruct).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetailsOdspInsightListStruct).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOdspInsightList")]
        public virtual void ResetOdspInsightList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "odspInsightList", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemOdspInsightDetailsOdspInsightListStructList\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemOdspInsightDetailsOdspInsightListStructList OdspInsightList
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemOdspInsightDetailsOdspInsightListStructList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kindInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KindInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetailsOdspInsightListStruct" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "odspInsightListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemOdspInsightDetailsOdspInsightListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OdspInsightListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemOdspInsightDetails\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetails? InternalValue
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
