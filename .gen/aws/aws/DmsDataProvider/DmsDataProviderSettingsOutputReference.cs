using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsDataProvider
{
    [JsiiClass(nativeType: typeof(aws.DmsDataProvider.DmsDataProviderSettingsOutputReference), fullyQualifiedName: "aws.dmsDataProvider.DmsDataProviderSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DmsDataProviderSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DmsDataProviderSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DmsDataProviderSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsDataProviderSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsDocDbSettings" />)[]</param>
        [JsiiMethod(name: "putDocDbSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsDocDbSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDocDbSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DmsDataProvider.IDmsDataProviderSettingsDocDbSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsDocDbSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsDocDbSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2LuwSettings" />)[]</param>
        [JsiiMethod(name: "putIbmDb2LuwSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsIbmDb2LuwSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIbmDb2LuwSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2LuwSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2LuwSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2LuwSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2ZosSettings" />)[]</param>
        [JsiiMethod(name: "putIbmDb2ZosSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsIbmDb2ZosSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIbmDb2ZosSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2ZosSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2ZosSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2ZosSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMariaDbSettings" />)[]</param>
        [JsiiMethod(name: "putMariaDbSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMariaDbSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMariaDbSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DmsDataProvider.IDmsDataProviderSettingsMariaDbSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsMariaDbSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsMariaDbSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMicrosoftSqlServerSettings" />)[]</param>
        [JsiiMethod(name: "putMicrosoftSqlServerSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMicrosoftSqlServerSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMicrosoftSqlServerSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DmsDataProvider.IDmsDataProviderSettingsMicrosoftSqlServerSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsMicrosoftSqlServerSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsMicrosoftSqlServerSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMongoDbSettings" />)[]</param>
        [JsiiMethod(name: "putMongoDbSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMongoDbSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMongoDbSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DmsDataProvider.IDmsDataProviderSettingsMongoDbSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsMongoDbSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsMongoDbSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMysqlSettings" />)[]</param>
        [JsiiMethod(name: "putMysqlSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMysqlSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMysqlSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DmsDataProvider.IDmsDataProviderSettingsMysqlSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsMysqlSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsMysqlSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsOracleSettings" />)[]</param>
        [JsiiMethod(name: "putOracleSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsOracleSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOracleSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DmsDataProvider.IDmsDataProviderSettingsOracleSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsOracleSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsOracleSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsPostgresqlSettings" />)[]</param>
        [JsiiMethod(name: "putPostgresqlSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsPostgresqlSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPostgresqlSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DmsDataProvider.IDmsDataProviderSettingsPostgresqlSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsPostgresqlSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsPostgresqlSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsRedshiftSettings" />)[]</param>
        [JsiiMethod(name: "putRedshiftSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsRedshiftSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRedshiftSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DmsDataProvider.IDmsDataProviderSettingsRedshiftSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsRedshiftSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsRedshiftSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsSybaseAseSettings" />)[]</param>
        [JsiiMethod(name: "putSybaseAseSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsSybaseAseSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSybaseAseSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.DmsDataProvider.IDmsDataProviderSettingsSybaseAseSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsSybaseAseSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettingsSybaseAseSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDocDbSettings")]
        public virtual void ResetDocDbSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIbmDb2LuwSettings")]
        public virtual void ResetIbmDb2LuwSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIbmDb2ZosSettings")]
        public virtual void ResetIbmDb2ZosSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMariaDbSettings")]
        public virtual void ResetMariaDbSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMicrosoftSqlServerSettings")]
        public virtual void ResetMicrosoftSqlServerSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMongoDbSettings")]
        public virtual void ResetMongoDbSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMysqlSettings")]
        public virtual void ResetMysqlSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOracleSettings")]
        public virtual void ResetOracleSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostgresqlSettings")]
        public virtual void ResetPostgresqlSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedshiftSettings")]
        public virtual void ResetRedshiftSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSybaseAseSettings")]
        public virtual void ResetSybaseAseSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "docDbSettings", typeJson: "{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsDocDbSettingsList\"}")]
        public virtual aws.DmsDataProvider.DmsDataProviderSettingsDocDbSettingsList DocDbSettings
        {
            get => GetInstanceProperty<aws.DmsDataProvider.DmsDataProviderSettingsDocDbSettingsList>()!;
        }

        [JsiiProperty(name: "ibmDb2LuwSettings", typeJson: "{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsIbmDb2LuwSettingsList\"}")]
        public virtual aws.DmsDataProvider.DmsDataProviderSettingsIbmDb2LuwSettingsList IbmDb2LuwSettings
        {
            get => GetInstanceProperty<aws.DmsDataProvider.DmsDataProviderSettingsIbmDb2LuwSettingsList>()!;
        }

        [JsiiProperty(name: "ibmDb2ZosSettings", typeJson: "{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsIbmDb2ZosSettingsList\"}")]
        public virtual aws.DmsDataProvider.DmsDataProviderSettingsIbmDb2ZosSettingsList IbmDb2ZosSettings
        {
            get => GetInstanceProperty<aws.DmsDataProvider.DmsDataProviderSettingsIbmDb2ZosSettingsList>()!;
        }

        [JsiiProperty(name: "mariaDbSettings", typeJson: "{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMariaDbSettingsList\"}")]
        public virtual aws.DmsDataProvider.DmsDataProviderSettingsMariaDbSettingsList MariaDbSettings
        {
            get => GetInstanceProperty<aws.DmsDataProvider.DmsDataProviderSettingsMariaDbSettingsList>()!;
        }

        [JsiiProperty(name: "microsoftSqlServerSettings", typeJson: "{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMicrosoftSqlServerSettingsList\"}")]
        public virtual aws.DmsDataProvider.DmsDataProviderSettingsMicrosoftSqlServerSettingsList MicrosoftSqlServerSettings
        {
            get => GetInstanceProperty<aws.DmsDataProvider.DmsDataProviderSettingsMicrosoftSqlServerSettingsList>()!;
        }

        [JsiiProperty(name: "mongoDbSettings", typeJson: "{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMongoDbSettingsList\"}")]
        public virtual aws.DmsDataProvider.DmsDataProviderSettingsMongoDbSettingsList MongoDbSettings
        {
            get => GetInstanceProperty<aws.DmsDataProvider.DmsDataProviderSettingsMongoDbSettingsList>()!;
        }

        [JsiiProperty(name: "mysqlSettings", typeJson: "{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMysqlSettingsList\"}")]
        public virtual aws.DmsDataProvider.DmsDataProviderSettingsMysqlSettingsList MysqlSettings
        {
            get => GetInstanceProperty<aws.DmsDataProvider.DmsDataProviderSettingsMysqlSettingsList>()!;
        }

        [JsiiProperty(name: "oracleSettings", typeJson: "{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsOracleSettingsList\"}")]
        public virtual aws.DmsDataProvider.DmsDataProviderSettingsOracleSettingsList OracleSettings
        {
            get => GetInstanceProperty<aws.DmsDataProvider.DmsDataProviderSettingsOracleSettingsList>()!;
        }

        [JsiiProperty(name: "postgresqlSettings", typeJson: "{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsPostgresqlSettingsList\"}")]
        public virtual aws.DmsDataProvider.DmsDataProviderSettingsPostgresqlSettingsList PostgresqlSettings
        {
            get => GetInstanceProperty<aws.DmsDataProvider.DmsDataProviderSettingsPostgresqlSettingsList>()!;
        }

        [JsiiProperty(name: "redshiftSettings", typeJson: "{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsRedshiftSettingsList\"}")]
        public virtual aws.DmsDataProvider.DmsDataProviderSettingsRedshiftSettingsList RedshiftSettings
        {
            get => GetInstanceProperty<aws.DmsDataProvider.DmsDataProviderSettingsRedshiftSettingsList>()!;
        }

        [JsiiProperty(name: "sybaseAseSettings", typeJson: "{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsSybaseAseSettingsList\"}")]
        public virtual aws.DmsDataProvider.DmsDataProviderSettingsSybaseAseSettingsList SybaseAseSettings
        {
            get => GetInstanceProperty<aws.DmsDataProvider.DmsDataProviderSettingsSybaseAseSettingsList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsDocDbSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "docDbSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsDocDbSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DocDbSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2LuwSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ibmDb2LuwSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsIbmDb2LuwSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IbmDb2LuwSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsIbmDb2ZosSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ibmDb2ZosSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsIbmDb2ZosSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IbmDb2ZosSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMariaDbSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mariaDbSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMariaDbSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MariaDbSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMicrosoftSqlServerSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "microsoftSqlServerSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMicrosoftSqlServerSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MicrosoftSqlServerSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMongoDbSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mongoDbSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMongoDbSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MongoDbSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsMysqlSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsMysqlSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MysqlSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsOracleSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oracleSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsOracleSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OracleSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsPostgresqlSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postgresqlSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsPostgresqlSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PostgresqlSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsRedshiftSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redshiftSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsRedshiftSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RedshiftSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DmsDataProvider.IDmsDataProviderSettingsSybaseAseSettings" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sybaseAseSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettingsSybaseAseSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SybaseAseSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.DmsDataProvider.IDmsDataProviderSettings" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.dmsDataProvider.DmsDataProviderSettings\"}]}}", isOptional: true)]
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
                        case aws.DmsDataProvider.IDmsDataProviderSettings cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DmsDataProvider.IDmsDataProviderSettings).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
