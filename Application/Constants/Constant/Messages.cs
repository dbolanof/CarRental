namespace Application.Constants
{
    /// <summary>
    /// Constant errros messages
    /// </summary>
    public static class Messages
    {
        public const string BaseError = "Se han presentado uno o más errores de validación";
        public const string NotFound = "El registro que inteta buscar (Id: {0}) no se encuentra en la base de datos";
        public const string RecordExist = "El registro que intenta agregar ya se encuentr con el identificador unico {0}";
        public const string MsjCreating = "Registro creado exitosamente";
    }
}
