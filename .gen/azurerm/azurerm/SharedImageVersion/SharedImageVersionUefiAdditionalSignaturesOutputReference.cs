using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SharedImageVersion
{
    [JsiiClass(nativeType: typeof(azurerm.SharedImageVersion.SharedImageVersionUefiAdditionalSignaturesOutputReference), fullyQualifiedName: "azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SharedImageVersionUefiAdditionalSignaturesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SharedImageVersionUefiAdditionalSignaturesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SharedImageVersionUefiAdditionalSignaturesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SharedImageVersionUefiAdditionalSignaturesOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDb" />)[]</param>
        [JsiiMethod(name: "putDb", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDb\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDb(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDb[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDb).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDb).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDbx" />)[]</param>
        [JsiiMethod(name: "putDbx", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDbx\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDbx(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDbx[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDbx).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDbx).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesKek" />)[]</param>
        [JsiiMethod(name: "putKek", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesKek\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutKek(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesKek[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesKek).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesKek).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesPk\"}}]")]
        public virtual void PutPk(azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesPk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesPk)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDb")]
        public virtual void ResetDb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbx")]
        public virtual void ResetDbx()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKek")]
        public virtual void ResetKek()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPk")]
        public virtual void ResetPk()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "db", typeJson: "{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDbList\"}")]
        public virtual azurerm.SharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDbList Db
        {
            get => GetInstanceProperty<azurerm.SharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDbList>()!;
        }

        [JsiiProperty(name: "dbx", typeJson: "{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDbxList\"}")]
        public virtual azurerm.SharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDbxList Dbx
        {
            get => GetInstanceProperty<azurerm.SharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDbxList>()!;
        }

        [JsiiProperty(name: "kek", typeJson: "{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesKekList\"}")]
        public virtual azurerm.SharedImageVersion.SharedImageVersionUefiAdditionalSignaturesKekList Kek
        {
            get => GetInstanceProperty<azurerm.SharedImageVersion.SharedImageVersionUefiAdditionalSignaturesKekList>()!;
        }

        [JsiiProperty(name: "pk", typeJson: "{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesPkOutputReference\"}")]
        public virtual azurerm.SharedImageVersion.SharedImageVersionUefiAdditionalSignaturesPkOutputReference Pk
        {
            get => GetInstanceProperty<azurerm.SharedImageVersion.SharedImageVersionUefiAdditionalSignaturesPkOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDb" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDb\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DbInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesDbx" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dbxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesDbx\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DbxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesKek" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kekInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesKek\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? KekInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pkInput", typeJson: "{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesPk\"}", isOptional: true)]
        public virtual azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesPk? PkInput
        {
            get => GetInstanceProperty<azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignaturesPk?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignatures\"}", isOptional: true)]
        public virtual azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignatures? InternalValue
        {
            get => GetInstanceProperty<azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignatures?>();
            set => SetInstanceProperty(value);
        }
    }
}
