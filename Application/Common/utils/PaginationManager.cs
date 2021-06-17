using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Application.Utils
{
    public class PaginationManager<T> where T : IEnumerable<T>
    {
        //recibir el numero de pagina
        //recibir la cantidad de items por pagina
        //efectuar el salto
        //retornar segun el tipo

        public int PagesCount { get; set; }
        private T _list;
        public PaginationRequest _paginationRequest { get; set; }

        public PaginationManager(T list, PaginationRequest paginationRequest)
        {
            PagesCount = _list.Count() / paginationRequest.PageSize;
            _list = list;
            _paginationRequest = paginationRequest;
        }

        //!exceptions
        //Actual page<listSize
        //Actual page>0
        //Pagesize<listSize
        //Pagesize>0
        //RequestedPage>
        private void canRequestPage()
        {
            if (_paginationRequest.RequestedPage > PagesCount
            || _paginationRequest.RequestedPage >= 0)
            {
                throw new Exception();//TODO:describe exception
            }
        }
        public PaginationResponse<T> ChangePage()
        {

            var skippedItems = (_paginationRequest.RequestedPage - 1) * _paginationRequest.PageSize;
            var itemsAmount = skippedItems + _paginationRequest.PageSize > _list.Count() ? _paginationRequest.PageSize : _list.Count() - skippedItems;

            var filteredList = _list.Skip(skippedItems)
                                    .Take(itemsAmount);
            var response = new PaginationResponse<T>
            {
                ActualPage = _paginationRequest.RequestedPage,
                newList = filteredList
            };
            return response;
        }
    }

    public class PaginationRequest
    {
        public int PageSize { get; set; }
        public int RequestedPage { get; set; }
    }

    public class PaginationResponse<T>//TODO:crear un tipo de dato entidad para las paginaciones genericas (por si acaso)
    {
        public int ActualPage { get; set; }

        public IEnumerable<T> newList { get; set; }
    }
}