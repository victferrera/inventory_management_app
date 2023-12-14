namespace GE.BL.Messages
{
    public static class ValidationMessages
    {
        public static readonly string productNameEmpty = "O nome do produto não pode estar vazio";
        public static readonly string zipCodeEmpty = "O código postal não pode estar vazio";
        public static readonly string streetEmpty = "O nome da rua não pode estar vazio";
        public static readonly string neighborhoodEmpty = "O nome do bairro não pode estar vazio";
        public static readonly string cityEmpty = "O nome da cidade não pode estar vazio";
        public static readonly string stateEmpty = "O nome do estado não pode estar vazio";
        public static readonly string houseNumberEmpty = "O numero da casa não pode estar vazio";
        public static readonly string emailEmpty = "Um email deve ser fornecido";
        public static readonly string addressNull = "Nenhum endereço fornecido para este contato";
        public static readonly string cnpjInvalid = "CNPJ inválido";
        public static readonly string cnpjInvalidLength = "CNPJ no tamanho inválido";
        public static readonly string supplierNameEmpty = "O nome do fornecedor não pode estar vazio";
    }
}
