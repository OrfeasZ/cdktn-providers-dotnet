using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DifStack
{
    [JsiiClass(nativeType: typeof(oci.DifStack.DifStackDataflowConnectionsConnectionDetailsOutputReference), fullyQualifiedName: "oci.difStack.DifStackDataflowConnectionsConnectionDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DifStackDataflowConnectionsConnectionDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DifStackDataflowConnectionsConnectionDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DifStackDataflowConnectionsConnectionDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DifStackDataflowConnectionsConnectionDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackDataflowConnectionsConnectionDetailsDifDependencies" />)[]</param>
        [JsiiMethod(name: "putDifDependencies", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackDataflowConnectionsConnectionDetailsDifDependencies\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDifDependencies(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DifStack.IDifStackDataflowConnectionsConnectionDetailsDifDependencies[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackDataflowConnectionsConnectionDetailsDifDependencies).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DifStack.IDifStackDataflowConnectionsConnectionDetailsDifDependencies).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDifDependencies")]
        public virtual void ResetDifDependencies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomainNames")]
        public virtual void ResetDomainNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "difDependencies", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowConnectionsConnectionDetailsDifDependenciesList\"}")]
        public virtual oci.DifStack.DifStackDataflowConnectionsConnectionDetailsDifDependenciesList DifDependencies
        {
            get => GetInstanceProperty<oci.DifStack.DifStackDataflowConnectionsConnectionDetailsDifDependenciesList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DifStack.IDifStackDataflowConnectionsConnectionDetailsDifDependencies" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "difDependenciesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.difStack.DifStackDataflowConnectionsConnectionDetailsDifDependencies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DifDependenciesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DomainNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "domainNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DomainNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.difStack.DifStackDataflowConnectionsConnectionDetails\"}", isOptional: true)]
        public virtual oci.DifStack.IDifStackDataflowConnectionsConnectionDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DifStack.IDifStackDataflowConnectionsConnectionDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
